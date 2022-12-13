<h1 align="center"> 💻 Laboratório AED - 07 (Revisão da Prova) </h1>

## ✔️ Linguagem utilizada
- ``C#``

## 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-PedroHCunhaV).

## 📝 Instruções de Utilização

- `Como Utilizar`:

Ao criar o projeto decidi colocar todas as atividades referentes ao primeiro laboratório em um único arquivo, devido a isso inseri no meu codigo um "do while" para repetir o código e um "switch-case" para escolha qual questão desejar executar.

Como mostrado no print a seguir, é possível ver a solicitação para escolher a questão da atividade: <br>
  ↳Lembrando que o "switch-case" para escolher a questão aceita somente números
![image](https://user-images.githubusercontent.com/101759330/205457661-2dc59ba1-5fa9-420a-b48d-cfba9925f7bd.png)

Ao final de cada questão é perguntando se deseja repetir o programa com uma resposta de "S/N":<br>
![image](https://user-images.githubusercontent.com/101759330/187083140-d5ada98b-869f-48fd-b3b2-87fa281aaa90.png)

## 🔨 Questões do Laboratório
- `Questão 1`:

Primeira Questão da Prova

- `Resposta Questão 1`:

Para a realização da Questão 01 era necessário realiza a leitura do arquivo e comparar o mesmo , para a realização disso utilizei o “StreamReader” para ler o que possui dentro do arquivo , solicitei para o usuário desejar um texto e armazenei em uma string e realizei a comparação através da utilização de if e else onde utiliza como comparação o texto escrito no arquivo.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Segunda Questão da Prova

- `Resposta Questão 2`:

Para a realização da Questão 02 era necessário utilizar o código que a questão disponibiliza para saber o resultado que o código iria dar. Que no caso deste código ficaria em loop infinito e causando erro no programa(Não chegando no ponto de parada logo não tendo nenhuma saída).

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Terceira Questão da Prova

- `Resposta Questão 3`:

Para a realização da Questão 03 foi realizada a criação de um arquivo de texto que continha a seguinte frase “Boa noite professor”. Para localizar e ler o que possuía dentro desse arquivo de texto foi utilizado o StreamReader e armazenado o texto que está no arquivo em uma variável string chamada arquivo. Logo após uma verificação para ver se a variável está vazia ou não, caso não esteja vazia ele exibe o texto antes de ser invertido para a comparação do usuário e após isso utiliza o “Reverse” para inverter o texto.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

Quarta Questão da Prova

- `Resposta Questão 4`:

Para a realização da Questão 04 era necessário a realização de um gerador de CPF’s válidos. Para a realização dessa questão foi necessário pesquisar sobre a composição do CPF. 

Os 8 primeiros números do CPF são aleatórios e seu 9º número é de acordo com o estado de 0 a 9 , no caso da questão realizada não foi necessário separar por estado , logo foi utilizado um Random para criar os primeiros 9 números.

Foi criado um vetor de tamanho igual a 11 com suas primeiras 9 posições sendo aleatórias. Foi criada duas funções, uma para a Décima posição e outra para a Décima Primeira posição. A Décima posição é realizada a multiplicação das noves posições do vetor por 10,9,8,7,6,5,4,3,2 cada posição por cada número respectivo, após isso é realizada a soma do resultado das multiplicações e depois dividir por onze e o resto da divisão é subtraído pelo número 11 o resultado será a Décima Posição.

A Décima Primeira posição é realizada a multiplicação a partir da segunda posição do vetor até a posição que foi adicionada que no caso é a posição 10, após realizar as multiplicações respectivas , novamente realiza a soma dos resultados das multiplicações , divide por 11 e o resto da divisão é subtraído pelo número 11 o resultado será a Décima Primeira posição.


----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 5`:

Quinta Questão da Prova

- `Resposta Questão 5`:

Para a realização da Questão 05 era necessário descobrir qual número do vetor seria exibido de acordo com o código. Após a realização do código e sua execução é possível ver que o valor que será exibido é “22”.
