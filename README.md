# Software para calcular os valores de THD

Motivação:
Quando usa-se um amplificador, ele chega num estado de saturação, neste estado ele passa a ter sua amplitude constante e sua frequência variando. Na verdade, o que ocorre é que aparecem harmônicos do sinal que acabam produzindo uma distorção no próprio sinal. Então, para ter o controle de quando o amplificador passa a variar a frequência e ter a relação de distorção do sinal, pois a distorção será aceitável até certo nível, será criado este software.

Função:
O programa deve se conectar com o osciloscópio da Keysight e se comunicar com ele para obter dados para plotar gráficos no domínio do tempo e da frequência com o uso da FFT. Além disso, será obtido os valores de tensão RMS de cada harmônico para se calcular o valor de distorção (THD) que depende diretamente deles.

Tutorial:
O tutorial que eu fiz encontra-se neste [link](https://www.youtube.com/watch?v=2pL2GOASWww&t=9s)
Neste tutorial foi criado um jogo da velha com a seguinte interface:

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Interface_tutorial_JV.PNG)

Esboço do Projeto:

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/Esboco.PNG)

De acordo com o novo [Fluxograma](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/THD%20-%20Fluxograma%20do%20Software.pdf), primeiro a conexão do osciloscópio deve ser bem sucedida, após isso informamos o valor da frequência fundamental e até qual harmônico deve ser considerado no cálculo do THDr, então, ao clicar em **Capturar** iniciamos obtenção dos dados e a plotar os gráficos de sinal de entrada no tempo, saída na frequência e saída no tempo. Assim, podemos visualizar a contribuição dos harmônicos na saída.
Após isso, temos a opção **Obter THDr**, que fornecerá o valor em porcentagem da distorção do sinal. Concluindo o objetivo.
Por fim, tem-se a opção **Parar**, que reseta os dados e a opção **Sair** para fechar o programa.

## Versão Inicial do Aplicativo

Nesta versão fazemos a inicialização, captura e análise de dados ao clicar em Capturar. Porém ainda não foi testado no osciloscópio, logo o objeto myScope não está sendo inicializado o que faz com que ocorra um erro e depois o fechamento do programa, que foi representado por uma caixa de mensagem escrito **Close**.

## Versão 2.0

Nesta segunda versão, tem-se a possibilidade de gerar entrada senoidal ou quadrada, obter a FFT, obter os valores de potência dos harmônicos.

## Interface da versão 2.0

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/ResultadoParcial5.PNG)

## Versão 2.4

Finalmente, nesta versão, foi alcançado o objetivo do projeto, que é o de calcular o valor de distorção total dos harmônicos. 

A partir das duas imagens a seguir, percebe-se que foi obtido uma onda quadrada e uma onda triangular como sinal de saída. Foi então calculado para elas os valores de THD, pois já conhecíamos os valores teóricos delas duas: 

THDf(Quadrada) = 48,3%

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/ResultadoFinal5.PNG)

THDf(Triangular) = 12.1%

![](https://github.com/ProgramacaoEE2018/brasil_harmonicos/blob/master/Imagens/ResultadoFinal6.PNG)
