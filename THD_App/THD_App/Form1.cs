using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ivi.Visa.Interop;
using System.Runtime.InteropServices;

namespace THD_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Tirando a legenda do gráfico e selecionando o tipo de gráfico
            chtGraf1.Legends.Clear();
            chtGraf1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chtGraf2.Legends.Clear();
            chtGraf2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chtGraf3.Legends.Clear();
            chtGraf3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;

            timer1.Enabled = false;
        }

        int x = 0;
        double thd_r, thd_f;

        private static VisaComInstrument myScope;

        /*
        * Initialize the oscilloscope to a known state.
        * --------------------------------------------------------------
        */
        private static void Initialize()
        {
            string strResults;
            // Get and display the device's *IDN? string.
            strResults = myScope.DoQueryString("*IDN?");

            MessageBox.Show("*IDN? result is: " + strResults, "Inicialização do Osciloscópio");
            //Console.WriteLine("*IDN? result is: {0}", strResults);
            // Clear status and load the default setup.
            myScope.DoCommand("*CLS");
            myScope.DoCommand("*RST");
        }
        /*
        * Capture the waveform.
        * --------------------------------------------------------------
        */
        private static void Capture()
        {
            // Use auto-scale to automatically configure oscilloscope.
            //myScope.DoCommand(":AUToscale");
            // Set trigger mode (EDGE, PULSe, PATTern, etc., and input source.
            myScope.DoCommand(":TRIGger:MODE EDGE");
            //MessageBox.Show("Trigger mode: " + myScope.DoQueryString(":TRIGger:MODE?"));
            // Set EDGE trigger parameters.
            myScope.DoCommand(":TRIGger:EDGE:SOURCe CHANnel1");
            //MessageBox.Show("Trigger edge source: " + myScope.DoQueryString(":TRIGger:EDGE:SOURce?"));
            myScope.DoCommand(":TRIGger:EDGE:LEVel 4.0");
            //MessageBox.Show("Trigger edge level: " + myScope.DoQueryString(":TRIGger:EDGE:LEVel?"));
            myScope.DoCommand(":TRIGger:EDGE:SLOPe POSitive");
            //MessageBox.Show("Trigger edge slope: " + myScope.DoQueryString(":TRIGger:EDGE:SLOPe?"));
            // Save oscilloscope configuration.
            byte[] ResultsArray; // Results array.
            int nLength; // Number of bytes returned from instrument.
            string strPath;
            // Query and read setup string.
            ResultsArray = myScope.DoQueryIEEEBlock(":SYSTem:SETup?");
            nLength = ResultsArray.Length;
            // Write setup string to file.
            strPath = "c:\\scope\\config\\setup.stp";
            FileStream fStream = File.Open(strPath, FileMode.Create);
            fStream.Write(ResultsArray, 0, nLength);
            fStream.Close();
            //MessageBox.Show("Setup bytes saved: " + nLength);
            // Change settings with individual commands:
            // Set vertical scale and offset.
            //myScope.DoCommand(":CHANnel1:SCALe 10.0");
            //MessageBox.Show("Channel 1 vertical scale: " + myScope.DoQueryString(":CHANnel1:SCALe?"));
            //myScope.DoCommand(":CHANnel1:OFFSet 0.0");
            //MessageBox.Show("Channel 1 vertical offset: " + myScope.DoQueryString(":CHANnel1:OFFSet?"));
            // Set horizontal scale and offset.
            //myScope.DoCommand(":TIMebase:SCALe 0.0002");
            //MessageBox.Show("Timebase scale: " + myScope.DoQueryString(":TIMebase:SCALe?"));
            myScope.DoCommand(":TIMebase:POSition 0.0");
            //MessageBox.Show("Timebase position: " + myScope.DoQueryString(":TIMebase:POSition?"));
            // Set the acquisition type (NORMal, PEAK, AVERage, or HRESolution
            myScope.DoCommand(":ACQuire:TYPE NORMal");
            //MessageBox.Show("Acquire type: " + myScope.DoQueryString(":ACQuire:TYPE?"));
            // Or, configure by loading a previously saved setup.
            byte[] DataArray;
            int nBytesWritten;
            // Read setup string from file.
            strPath = "c:\\scope\\config\\setup.stp";
            DataArray = File.ReadAllBytes(strPath);
            nBytesWritten = DataArray.Length;
            // Restore setup string.
            myScope.DoCommandIEEEBlock(":SYSTem:SETup", DataArray);
            MessageBox.Show("Setup bytes restored: " + nBytesWritten);
            // Capture an acquisition using :DIGitize.
            //myScope.DoCommand(":DIGitize CHANnel1");
        }
        /*
        * Analyze the captured waveform.
        * --------------------------------------------------------------
        */
        static double freqFund, vRMSChan1;
        static string teste;
        static byte[] pontoGraf2 = new byte[50000], pontoGraf3 = new byte[50000];

        private static void Analyze()
        {
            byte[] ResultsArray; // Results array.
            int nLength; // Number of bytes returned from instrument.
            string strPath;
            // Make a couple of measurements.
            // -----------------------------------------------------------
            myScope.DoCommand(":MEASure:SOURce CHANnel1");
            MessageBox.Show("Measure source: " + myScope.DoQueryString(":MEASure:SOURce?"));
            double fResult;
            //myScope.DoCommand(":MEASure:FREQuency");
            fResult = myScope.DoQueryNumber(":MEASure:FREQuency?");
            freqFund = fResult / 1000;
            //MessageBox.Show(freqFund.ToString() + "kHz", "Frequência");
            myScope.DoCommand(":MEASure:VAMPlitude");

            vRMSChan1 = myScope.DoQueryNumber(":MEASure:VRMS?");
            //MessageBox.Show(fResult.ToString(), "VRMS");
            // Download the screen image.
            // -----------------------------------------------------------
            myScope.DoCommand(":HARDcopy:INKSaver OFF");
            // Get the screen data.
            ResultsArray =
            myScope.DoQueryIEEEBlock(":DISPlay:DATA? PNG, COLor");
            nLength = ResultsArray.Length;
            // Store the screen data to a file.
            strPath = "c:\\scope\\data\\screen.png";
            FileStream fStream = File.Open(strPath, FileMode.Create);
            fStream.Write(ResultsArray, 0, nLength);
            fStream.Close();
            MessageBox.Show("Screen image (" + nLength + " bytes) written to " + strPath);
            // Download waveform data.
            // -----------------------------------------------------------
            // Set the waveform points mode.
            myScope.DoCommand(":WAVeform:POINts:MODE RAW");
            MessageBox.Show("Waveform points mode: " + myScope.DoQueryString(":WAVeform:POINts:MODE?"));
            // Get the number of waveform points available.
            MessageBox.Show("Waveform points available: " + myScope.DoQueryString(":WAVeform:POINts?"));

            // Set the waveform source.
            myScope.DoCommand(":WAVeform:SOURce CHANnel1");
            MessageBox.Show("Waveform source: " + myScope.DoQueryString(":WAVeform:SOURce?"));
            // Choose the format of the data returned (WORD, BYTE, ASCII):
            myScope.DoCommand(":WAVeform:FORMat BYTE");
            MessageBox.Show("Waveform format: " + myScope.DoQueryString(":WAVeform:FORMat?"));
            // Display the waveform settings:
            double[] fResultsArray;
            fResultsArray = myScope.DoQueryNumbers(":WAVeform:PREamble?");
            double fFormat = fResultsArray[0];
            if (fFormat == 0.0)
            {
                Console.WriteLine("Waveform format: BYTE");
            }
            else if (fFormat == 1.0)
            {
                Console.WriteLine("Waveform format: WORD");
            }
            else if (fFormat == 2.0)
            {
                Console.WriteLine("Waveform format: ASCii");
            }
            double fType = fResultsArray[1];
            if (fType == 0.0)
            {
                Console.WriteLine("Acquire type: NORMal");
            }
            else if (fType == 1.0)
            {
                Console.WriteLine("Acquire type: PEAK");
            }
            else if (fType == 2.0)
            {
                Console.WriteLine("Acquire type: AVERage");
            }
            else if (fType == 3.0)
            {
                Console.WriteLine("Acquire type: HRESolution");
            }
            double fPoints = fResultsArray[2];
            MessageBox.Show("Waveform points: " + fPoints);
            double fCount = fResultsArray[3];
            MessageBox.Show("Waveform average count: " + fCount);
            double fXincrement = fResultsArray[4];
            MessageBox.Show("Waveform X increment: " + fXincrement);
            double fXorigin = fResultsArray[5];
            MessageBox.Show("Waveform X origin: " + fXorigin);
            double fXreference = fResultsArray[6];
            MessageBox.Show("Waveform X reference: " + fXreference);
            double fYincrement = fResultsArray[7];
            MessageBox.Show("Waveform Y increment: " + fYincrement);
            double fYorigin = fResultsArray[8];
            MessageBox.Show("Waveform Y origin: " + fYorigin);
            double fYreference = fResultsArray[9];
            MessageBox.Show("Waveform Y reference: " + fYreference);
            // Read waveform data.
            ResultsArray = myScope.DoQueryIEEEBlock(":WAVeform:DATA?");

            pontoGraf2 = ResultsArray;
            MessageBox.Show(pontoGraf2.Length.ToString());

            nLength = ResultsArray.Length;
            // Set up output file:
            strPath = "c:\\scope\\data\\waveform_data.csv";
            if (File.Exists(strPath)) File.Delete(strPath);
            // Open file for output.
            StreamWriter writer = File.CreateText(strPath);
            // Output waveform data in CSV format.
            for (int i = 0; i < nLength - 1; i++)
                writer.WriteLine("{0:f9}, {1:f6}",
                fXorigin + ((float)i * fXincrement),
                (((float)ResultsArray[i] - fYreference)
                * fYincrement) + fYorigin);
            // Close output file.
            writer.Close();
            Console.WriteLine("Waveform format BYTE data written to {0}",
            strPath);

            // Set the waveform source.
            myScope.DoCommand(":WAVeform:SOURce FFT");
            MessageBox.Show("Waveform source: " + myScope.DoQueryString(":WAVeform:SOURce?"));
            // Choose the format of the data returned (WORD, BYTE, ASCII):
            myScope.DoCommand(":WAVeform:FORMat BYTE");
            MessageBox.Show("Waveform format: " + myScope.DoQueryString(":WAVeform:FORMat?"));
            ResultsArray = myScope.DoQueryIEEEBlock(":WAVeform:DATA?");
            pontoGraf3 = ResultsArray;
            MessageBox.Show(pontoGraf3.Length.ToString());
        }

        private void btInicializar_Click(object sender, EventArgs e)
        {
            try
            {
                myScope = new
                    VisaComInstrument("USB0::0x2A8D::0x179B::CN57342208::0::INSTR"
                    );
                myScope.SetTimeoutSeconds(10);
                // Initialize - start from a known state.
                Initialize();
                btInicializar.Enabled = false;
            }
            catch (System.ApplicationException err)
            {
                MessageBox.Show("*** VISA COM Error : " + err.Message);
            }
            catch (System.SystemException err)
            {
                MessageBox.Show("*** System Error Message : " + err.Message);
            }
            catch (System.Exception err)
            {
                System.Diagnostics.Debug.Fail("Unexpected Error");
                MessageBox.Show("*** Unexpected Error : " + err.Message);
            }
            finally
            {
                //if (MessageBox.Show("Tentar reconectar?", "Osciloscópio Desconectado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                //{
                //    myScope.Close();
                //}
                //else
                  //  btInicializar.Enabled = true;
            }
        }

        private void btGerarEntrada_Click(object sender, EventArgs e)
        {
            genWave();
            fftCapture();
            fftMeasure();
        }

        private void btObterSaida_Click(object sender, EventArgs e)
        {
            // Capture data.
            Capture();
            // Analyze the captured waveform.
            Analyze();
            lbVrmsFund.Text = freqFund.ToString() + "kHz";
            //lbVrmsNHarm.Text = vRMSChan1.ToString() + "V";

            for (int i = 0; i < pontoGraf2.Length; i++)
                {
                    chtGraf2.Series[0].Points.AddY(pontoGraf2[i]);
                }
            for (int i = 0; i < pontoGraf3.Length; i++)
            {
                chtGraf3.Series[0].Points.AddY(pontoGraf3[i]);
            }
        }

        private void genWave()
        {
            myScope.DoCommand(":WGEN:FREQuency " + tbFreq.Text);
            //myScope.DoCommand(":WGEN:FUNCtion:SINusoid");
            myScope.DoCommand(":WGEN:FUNCtion SQUare");
            myScope.DoCommand(":WGEN:VOLTage:OFFSet 0.0");
            myScope.DoCommand(":WGEN:VOLTage 9.0");
            myScope.DoCommand(":WGEN:OUTPut 1");
            myScope.DoCommand(":AUToscale");
            MessageBox.Show("Amplitude 9.0 \nOffSet 0.0 \nWave Form Sinusoid", "Generated Wave");
            
        }

        private void fftCapture()
        {
            myScope.DoCommand(":FFT:SOURce1 CHANnel1");
            myScope.DoCommand(":FFT:CENTer 20000");
            myScope.DoCommand(":FFT:SPAN 50000");
            myScope.DoCommand(":FFT:VTYPe VRMS");
            myScope.DoCommand(":FFT:SCALe 0.5");
            myScope.DoCommand(":FFT:OFFSet 1.9812");
            myScope.DoCommand(":FFT:DISPlay 1");
            myScope.DoCommand(":CHANnel1:DISPlay 0");
        }

        private void fftMeasure()
        {
            //myScope.DoCommand(":MEASure:ALL");
            myScope.DoCommand(":MEASure:VMAX FFT");
            lbVrmsNHarm.Text = myScope.DoQueryNumber(":MEASure:VMAX? FFT").ToString();
        }

        private void btTHDr_Click(object sender, EventArgs e)
            {
                thd_r = new Random().NextDouble();
                thd_r = thd_r * 100;
                listView1.Items.Add(thd_r.ToString("#") + "%");
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chtGraf1.Series[0].Points.Count > 30)
            {
                chtGraf1.Series[0].Points.RemoveAt(0);
                chtGraf1.Update();
            }
            chtGraf1.Series[0].Points.AddXY(x++, new Random().NextDouble());

            if (chtGraf3.Series[0].Points.Count > 20)
            {
                chtGraf3.Series[0].Points.RemoveAt(0);
                chtGraf3.Update();
            }
            chtGraf3.Series[0].Points.AddY(new Random().NextDouble());
        }

        private void btLimparDados_Click(object sender, EventArgs e)
        {
            chtGraf1.Series[0].Points.Clear();
            chtGraf2.Series[0].Points.Clear();
            chtGraf3.Series[0].Points.Clear();
            lbVrmsFund.Text = "";
            lbVrmsNHarm.Text = "";
            tbFreq.Text = "";
            tbHarmN.Text = "";
            btInicializar.Enabled = true;
            timer1.Enabled = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar o aplicativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == (DialogResult.Yes))
            {
                Close();
            }
        }
    }

    class VisaComInstrument
    {
        private ResourceManager m_ResourceManager;
        private FormattedIO488 m_IoObject;
        private string m_strVisaAddress;
        // Constructor
        public VisaComInstrument(string strVisaAddress)
        {
            // Save VISA address in member variable.
            m_strVisaAddress = strVisaAddress;
            // Open the default VISA COM IO object.
            OpenIo();
            // Clear the interface.
            m_IoObject.IO.Clear();
        }
        public void DoCommand(string strCommand)
        {
            // Send the command.
            m_IoObject.WriteString(strCommand, true);
            // Check for inst errors.
            CheckInstrumentErrors(strCommand);
        }
        public void DoCommandIEEEBlock(string strCommand,
        byte[] DataArray)
        {
            // Send the command to the device.
            m_IoObject.WriteIEEEBlock(strCommand, DataArray, true);
            // Check for inst errors.
            CheckInstrumentErrors(strCommand);
        }
        public string DoQueryString(string strQuery)
        {
            // Send the query.
            m_IoObject.WriteString(strQuery, true);
            // Get the result string.
            string strResults;
            strResults = m_IoObject.ReadString();
            // Check for inst errors.
            CheckInstrumentErrors(strQuery);
            // Return results string.
            return strResults;
        }
        public double DoQueryNumber(string strQuery)
        {
            // Send the query.
            m_IoObject.WriteString(strQuery, true);
            // Get the result number.
            double fResult;
            fResult = (double)m_IoObject.ReadNumber(
            IEEEASCIIType.ASCIIType_R8, true);
            // Check for inst errors.
            CheckInstrumentErrors(strQuery);
            // Return result number.
            return fResult;
        }
        public double[] DoQueryNumbers(string strQuery)
        {
            // Send the query.
            m_IoObject.WriteString(strQuery, true);
            // Get the result numbers.
            double[] fResultsArray;
            fResultsArray = (double[])m_IoObject.ReadList(
            IEEEASCIIType.ASCIIType_R8, ",;");
            // Check for inst errors.
            CheckInstrumentErrors(strQuery);
            // Return result numbers.
            return fResultsArray;
        }
        public byte[] DoQueryIEEEBlock(string strQuery)
        {
            // Send the query.
            m_IoObject.WriteString(strQuery, true);
            // Get the results array.
            System.Threading.Thread.Sleep(2000); // Delay before reading.
            byte[] ResultsArray;
            ResultsArray = (byte[])m_IoObject.ReadIEEEBlock(
            IEEEBinaryType.BinaryType_UI1, false, true);
            // Check for inst errors.
            CheckInstrumentErrors(strQuery);
            // Return results array.
            return ResultsArray;
        }
        private void CheckInstrumentErrors(string strCommand)
        {
            // Check for instrument errors.
            string strInstrumentError;
            bool bFirstError = true;
            do // While not "0,No error".
            {
                m_IoObject.WriteString(":SYSTem:ERRor?", true);
                strInstrumentError = m_IoObject.ReadString();
                if (!strInstrumentError.ToString().StartsWith("+0,"))
                {
                    if (bFirstError)
                    {
                        Console.WriteLine("ERROR(s) for command '{0}': ",
                        strCommand);
                        bFirstError = false;
                    }
                    Console.Write(strInstrumentError);
                }
            } while (!strInstrumentError.ToString().StartsWith("+0,"));
        }
        private void OpenIo()
        {
            m_ResourceManager = new ResourceManager();
            m_IoObject = new FormattedIO488();
            // Open the default VISA COM IO object.
            try
            {
                m_IoObject.IO =
                (IMessage)m_ResourceManager.Open(m_strVisaAddress,
                AccessMode.NO_LOCK, 0, "");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: {0}", e.Message);
            }
        }
        public void SetTimeoutSeconds(int nSeconds)
        {
            m_IoObject.IO.Timeout = nSeconds * 1000;
        }

        public void Close()
        {
            try
            {
                m_IoObject.IO.Close();
            }
            catch { }
            try
            {
                Marshal.ReleaseComObject(m_IoObject);
            }
            catch { }
            try
            {
                Marshal.ReleaseComObject(m_ResourceManager);
            }
            catch { }
        }
    }
}
