# Software para calcular os valores de THD

Conceito de THD:
THD (Total Harmonic Distortion) é um fator de distorção de um sinal, que indica o quão distorcido está o sinal analisando as potências dos harmônicos em relação a potência da frequência fundamental.

Motivação:
Quando usa-se um amplificador, ele chega num estado de saturação, neste estado ele passa a ter sua amplitude constante e sua frequência variando. Na verdade, o que ocorre é que aparecem harmônicos do sinal que acabam produzindo uma distorção no próprio sinal. Então será criado este software, para ter o controle da distorção do sinal, ou seja, para saber quando o sinal passa a ter uma distorção significativa e do valor dessa distorção.

Função:
O programa deve se conectar com o osciloscópio da Keysight e se comunicar com ele para obter dados para plotar gráficos no domínio do tempo e da frequência com o uso da FFT. Além disso, será obtido os valores de tensão RMS de cada harmônico para se calcular o valor de distorção (THD) que depende diretamente deles.

Tutorial:
O tutorial que eu fiz encontra-se neste [link](https://www.youtube.com/watch?v=2pL2GOASWww&t=9s)
Neste tutorial foi criado um jogo da velha com a seguinte interface:

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Interface_tutorial_JV.PNG)

## Fluxograma
![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Fluxograma%20do%20Software%20do%20THD.png)

## Diagrama de Classes
![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Diagrama%20de%20classes%20e%20relacionamentos.png)

## Esboço da GUI

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Esboco.PNG)

De acordo com o Fluxograma, primeiro a conexão do osciloscópio deve ser bem sucedida, após isso informamos o valor da frequência fundamental e até qual harmônico deve ser considerado no cálculo do THDr, então, ao clicar em **Capturar** iniciamos obtenção dos dados e a plotar os gráficos de sinal de entrada no tempo, saída na frequência e saída no tempo. Assim, podemos visualizar a contribuição dos harmônicos na saída.
Após isso, temos a opção **Obter THDr**, que fornecerá o valor em porcentagem da distorção do sinal. Concluindo o objetivo.
Por fim, tem-se a opção **Parar**, que reseta os dados e a opção **Sair** para fechar o programa.

## Versão 2.4

Finalmente, nesta versão, foi alcançado o objetivo do projeto, que é o de calcular o valor de distorção total dos harmônicos. 

A partir das duas imagens a seguir, percebe-se que foi obtido uma onda quadrada e uma onda triangular como sinal de saída. Foi então calculado para elas os valores de THD, pois já conhecíamos os valores teóricos delas duas: 

THDf(Quadrada) = 48,3%

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/ResultadoFinal5.1.PNG)

THDf(Triangular) = 12.1%

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/ResultadoFinal6.1.PNG)

## Instruções de Compilação

Para compilar o programa foi necessário a atualização da versão do .NET Framework para a versão 4.5.1, que pode ser encontrada neste [LINK](https://www.microsoft.com/pt-br/download/details.aspx?id=30653).

O .NET Framework deve ser atualizado para aceitar algumas funções utilizadas no Windows Forms e aceitar a atualização da referência VISA COM Library para a VISA COM 5.9 Type Library que será atualizada com a instalação da IO Libraries Suite que pode ser baixado neste [LINK](http://www.keysight.com/find/iolib).
Após a Atualização do .NET Framework e do IO Lbraries Suite, o programa estará pronto para funcionar!

## Código funcional
[LINK](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/THD_App%204k%20X%20Series/THD_App/Form1.cs) do código funcional.
