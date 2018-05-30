# Software para calcular os valores de THD

Motivação:
Quando usa-se um amplificador, ele chega num estado de saturação, neste estado ele passa a ter sua amplitude constante e sua frequência variando. Então, seria muito bom ter o controle de quando o amplificador passa a variar a frequência e ter a relação de frequência, caso seja aceitável ter a frequência um pouco diferente até certo ponto. 

Função:
O programa deve se conectar com o osciloscópio e pegar os dados dele para plotar gráficos, a partir desses gráficos e dos dados obtidos calcular a frequência do harmônico e então fornecer a relação entre a frequência obtida e a desejada.

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

## Próximo passo
Testar este programa no osciloscópio.
