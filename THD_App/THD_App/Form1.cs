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

            //Tirando a legenda do gráfico
            chtGraf1.Legends.Clear();
            chtGraf2.Legends.Clear();
            chtGraf3.Legends.Clear();

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
            // Set trigger mode (EDGE, PULSe, PATTern, etc., and input source.
            myScope.DoCommand(":TRIGger:MODE EDGE");
            // Set EDGE trigger parameters.
            myScope.DoCommand(":TRIGger:EDGE:SOURCe CHANnel1");
            myScope.DoCommand(":TRIGger:EDGE:LEVel 1.0");
            myScope.DoCommand(":TRIGger:EDGE:SLOPe POSitive");
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
            // Change settings with individual commands:
            // Set scale and offset.
            //myScope.DoCommand(":CHANnel1:SCALe 10.0");
            //myScope.DoCommand(":CHANnel1:OFFSet 0.0");
            //myScope.DoCommand(":TIMebase:SCALe 0.0002");
            myScope.DoCommand(":TIMebase:POSition 0.0");
            // Set the acquisition type (NORMal, PEAK, AVERage, or HRESolution
            myScope.DoCommand(":ACQuire:TYPE NORMal");
            // Or, configure by loading a previously saved setup.
            byte[] DataArray;
            int nBytesWritten;
            // Read setup string from file.
            strPath = "c:\\scope\\config\\setup.stp";
            DataArray = File.ReadAllBytes(strPath);
            nBytesWritten = DataArray.Length;
            // Restore setup string.
            myScope.DoCommandIEEEBlock(":SYSTem:SETup", DataArray);
        }
        /*
        * Analyze the captured waveform.
        * --------------------------------------------------------------
        */

        static byte[] pontoGraf2 = new byte[50000], pontoGraf3 = new byte[50000];

        private static void Analyze()
        {
            byte[] ResultsArray; // Results array.
            // Make a couple of measurements.
            // -----------------------------------------------------------
            myScope.DoCommand(":MEASure:SOURce CHANnel1");
            MessageBox.Show("Measure source: " + myScope.DoQueryString(":MEASure:SOURce?"));

            // Download waveform data.
            // -----------------------------------------------------------
            // Set the waveform points mode
            myScope.DoCommand(":WAVeform:POINts:MODE RAW");
            //Não está mudando o MODE
            MessageBox.Show("Waveform points mode: " + myScope.DoQueryString(":WAVeform:POINts:MODE?"));
            // Get the number of waveform points available.
            MessageBox.Show("Waveform points available: " + myScope.DoQueryString(":WAVeform:POINts?"));

            // Set the waveform source.
            myScope.DoCommand(":WAVeform:SOURce CHANnel1");
            MessageBox.Show("Waveform source: " + myScope.DoQueryString(":WAVeform:SOURce?"));
            // Choose the format of the data returned (WORD, BYTE, ASCII):
            myScope.DoCommand(":WAVeform:FORMat BYTE");
            MessageBox.Show("Waveform format: " + myScope.DoQueryString(":WAVeform:FORMat?"));
            // Read waveform data.
            ResultsArray = myScope.DoQueryIEEEBlock(":WAVeform:DATA?");
            pontoGraf2 = ResultsArray;
            MessageBox.Show(pontoGraf2.Length.ToString(), "Pontos do grafico 2");

            // Set the waveform source.
            myScope.DoCommand(":WAVeform:SOURce FFT");
            MessageBox.Show("Waveform source: " + myScope.DoQueryString(":WAVeform:SOURce?"));
            // Choose the format of the data returned (WORD, BYTE, ASCII):
            myScope.DoCommand(":WAVeform:FORMat BYTE");
            MessageBox.Show("Waveform format: " + myScope.DoQueryString(":WAVeform:FORMat?"));
            // Read waveform data.
            ResultsArray = myScope.DoQueryIEEEBlock(":WAVeform:DATA?");
            pontoGraf3 = ResultsArray;
            MessageBox.Show(pontoGraf3.Length.ToString(), "Pontos do grafico 3");
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
        }

        static string forma;

        private void genWave()
        {
            
            myScope.DoCommand(":WGEN:FREQuency " + tbFreq.Text);
            if (rbSin.Checked == true)
            {
                myScope.DoCommand(":WGEN:FUNCtion SINusoid");
                forma = "Senoidal";
            }
            else if (rbSquare.Checked == true)
            {
                myScope.DoCommand(":WGEN:FUNCtion SQUare");
                forma = "Quadrada";
            }
            myScope.DoCommand(":WGEN:VOLTage:OFFSet 0.0");
            myScope.DoCommand(":WGEN:VOLTage 9.0");
            myScope.DoCommand(":WGEN:OUTPut 1");
            waveCapture();
            MessageBox.Show("Amplitude = 9.0\nOffSet = 0.0 \nWave Form: " + forma, "Generated Wave");
        }

        private void waveCapture()
        {
            myScope.DoCommand(":AUToscale");
            // Set the waveform source.
            myScope.DoCommand(":WAVeform:SOURce CHANnel1");
            myScope.DoCommand(":MEASure:VMAX");
            myScope.DoCommand(":MEASure:VRMS");
            MessageBox.Show("Vmax = " + myScope.DoQueryNumber(":MEASure:VMAX?").ToString() + " V\nVrms = " + myScope.DoQueryNumber(":MEASure:VRMS?").ToString() + "V" , myScope.DoQueryString(":WAVeform:SOURce?"));
            myScope.DoCommand(":MEASure:FREQuency");
        }

        private void fftCapture()
        {
            int multipSPAN = 40;
            myScope.DoCommand(":FFT:SOURce1 CHANnel1");
            myScope.DoCommand(":FFT:SPAN " + (multipSPAN*myScope.DoQueryNumber(":MEASure:FREQuency?")).ToString());
            myScope.DoCommand(":FFT:CENTer " + (myScope.DoQueryNumber(":FFT:SPAN?")/2).ToString());
            myScope.DoCommand(":FFT:VTYPe VRMS");
            myScope.DoCommand(":FFT:SCALe 0.5");
            myScope.DoCommand(":FFT:OFFSet 1.9812");
            myScope.DoCommand(":FFT:DISPlay 1");
            myScope.DoCommand(":CHANnel1:DISPlay 0");
        }

        private void fftMeasure()
        {
            myScope.DoCommand(":MEASure:VMAX FFT");
            MessageBox.Show("VRMSfund = " + myScope.DoQueryNumber(":MEASure:VMAX? FFT").ToString(), "Medidas da FFT");
            lbVrmsFFund.Text = myScope.DoQueryNumber(":MEASure:VMAX? FFT").ToString() + "V";
        }

        private int[] maxArrayByte(byte[] vetor)
        {
            int[] xy = new int[] { 0, 0 };

            for (int i = 0; i < vetor.Length; i++)
            {
                if (xy[1] < vetor[i])
                {
                    xy[1] = vetor[i];
                    xy[0] = i;
                }
            }

            return xy;
        }

        private double[] byte2volt(byte[] vetor)
        {
            double[] aux = new double[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                aux[i] = vetor[i] * 16.0 / 255.0 - 8;
            }

            return aux;
        }

        private void btObterSaida_Click(object sender, EventArgs e)
        {
            int[] graf3xy = new int[2];
            double[] valores = new double[50000];

            fftCapture();
            fftMeasure();
            MessageBox.Show("Medidas da FFT foram feitas com sucesso!", "Grafico 3");
            // Capture data.
            Capture();
            // Analyze the captured waveform.
            Analyze();

            chtGraf1.Series[0].Points.Clear();
            chtGraf2.Series[0].Points.Clear();
            chtGraf3.Series[0].Points.Clear();

            for (int i = 0; i < pontoGraf2.Length; i++)
            {
                chtGraf2.Series[0].Points.AddY(pontoGraf2[i]);
            }
            for (int i = 0; i < pontoGraf3.Length; i++)
            {
                chtGraf3.Series[0].Points.AddY(pontoGraf3[i]);
            }

            graf3xy = maxArrayByte(pontoGraf3);
            MessageBox.Show(graf3xy[0].ToString() + " e " + graf3xy[1].ToString());

            valores = byte2volt(pontoGraf3);

            for(int n = 1; n <= numNHarm.Value ; n++)
            {
                listView2.Items.Add(valores[n*graf3xy[0]].ToString() + " V");
            }
        }        

        private void btTHDr_Click(object sender, EventArgs e)
            {
                thd_r = new Random().NextDouble();
                thd_r = thd_r * 100;
                listView1.Items.Add(thd_r.ToString("#") + "%");
            }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btLimparDados_Click(object sender, EventArgs e)
        {
            chtGraf1.Series[0].Points.Clear();
            chtGraf2.Series[0].Points.Clear();
            chtGraf3.Series[0].Points.Clear();
            lbVrmsFFund.Text = "";
            lbVrmsNHarm.Text = "";
            tbFreq.Text = "";
            numNHarm.Value = 2;
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
