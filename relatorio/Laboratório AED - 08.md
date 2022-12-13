<h1 align="center"> 💻 Laboratório AED - 08 </h1>

## ✔️ Linguagem utilizada
- ``C#``

## 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-PedroHCunhaV).

## 📝 Instruções de Utilização

- `Como Utilizar`:

Ao criar o projeto decidi colocar todas as atividades referentes ao primeiro laboratório em um único arquivo, devido a isso inseri no meu codigo um "do while" para repetir o código e um "switch-case" para escolha qual questão desejar executar.

Como mostrado no print a seguir, é possível ver a solicitação para escolher a questão da atividade: <br>
  ↳Lembrando que o "switch-case" para escolher a questão aceita somente números
![image](https://user-images.githubusercontent.com/101759330/207328761-771b4ad2-8f84-4166-92cc-5bac41d8f21d.png)

Ao final de cada questão é perguntando se deseja repetir o programa com uma resposta de "S/N":<br>
![image](https://user-images.githubusercontent.com/101759330/187083140-d5ada98b-869f-48fd-b3b2-87fa281aaa90.png)

## 🔨 Questões do Laboratório
- `Questão 1`: 

Atividade Referente a utilização de Fila Estática

- `Resposta Questão 1`:

Para a realização da Fila Estática e suas ações (inserir,remover e visualizar), realizei a criação do vetor de tamanho 5 e de uma variavel que será utilizada para saber as posições e o tamanho máximo do vetor. Foi realizado um menu de seleção para que o usuário escolha qual ação ele deseja realizar, esse menu foi realizado através de um do-while para que quando o usuário realizasse uma ação ele pudesse repetir a ação ou escolher outra. Dentro do do-while possui um switch case que cada caso chama a função de cada ação(Inserir,Remover e Visualizar).Para Inserir os valores no vetor foi realizado a criação de uma função onde passa como parametros o vetor e a variavel de parametro de tamanho, nessa função possui um if para saber se o vetor ja esta preenchido caso já esta preenchido não é possível realizar a inserção, caso não esteja cheio solicita que o usuário digite o valor que deseja inserir e o mesmo lê o valor na primeira posição disponivel.Para a função de remover da fila foi utilizada uma variavel auxiliar para guardar o valor da primeira posição do vetor e a utilização de um for onde é realizada a troca das posições e o ajuste das demais posições. A função para Visualizar foi feita através de um for onde o mesmo verificar em cada posição do vetor se a mesma esta preenchida se tiver preenchida ele imprime o valor que esta na posição caso não esteja preenchida exibe como vazia, através do for isso é realizado em cada posição do vetor de acordo com o seu tamanho.

![image](https://user-images.githubusercontent.com/101759330/207335396-8ef1e0c7-dcdc-4dbc-a0f1-78d82527886b.png)

#Inserção
![image](https://user-images.githubusercontent.com/101759330/207335827-27afbae6-0edd-459f-ac9e-3950826899d2.png)

#Remoção
![ada](https://user-images.githubusercontent.com/101759330/207337679-dfeeb800-2551-46fa-ae88-aa3db294d4fc.png)

#Visualização
![aba](https://user-images.githubusercontent.com/101759330/207338246-1e526e3b-a51c-42f3-8ece-7f024dea5ce6.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Segunda Questão 

- `Resposta Questão 2`:

Para a realização da Questão 02 era necessário utilizar o código que a questão disponibiliza para saber o resultado que o código iria dar. Que no caso deste código ficaria em loop infinito e causando erro no programa(Não chegando no ponto de parada logo não tendo nenhuma saída).

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Terceira Questão 

- `Resposta Questão 3`:

Para a realização da Questão 03 foi realizada a criação de um arquivo de texto que continha a seguinte frase “Boa noite professor”. Para localizar e ler o que possuía dentro desse arquivo de texto foi utilizado o StreamReader e armazenado o texto que está no arquivo em uma variável string chamada arquivo. Logo após uma verificação para ver se a variável está vazia ou não, caso não esteja vazia ele exibe o texto antes de ser invertido para a comparação do usuário e após isso utiliza o “Reverse” para inverter o texto.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

Quarta Questão 

- `Resposta Questão 4`:

Para a realização da Questão 04 era necessário a realização de um gerador de CPF’s válidos. Para a realização dessa questão foi necessário pesquisar sobre a composição do CPF. 

Os 8 primeiros números do CPF são aleatórios e seu 9º número é de acordo com o estado de 0 a 9 , no caso da questão realizada não foi necessário separar por estado , logo foi utilizado um Random para criar os primeiros 9 números.

Foi criado um vetor de tamanho igual a 11 com suas primeiras 9 posições sendo aleatórias. Foi criada duas funções, uma para a Décima posição e outra para a Décima Primeira posição. A Décima posição é realizada a multiplicação das noves posições do vetor por 10,9,8,7,6,5,4,3,2 cada posição por cada número respectivo, após isso é realizada a soma do resultado das multiplicações e depois dividir por onze e o resto da divisão é subtraído pelo número 11 o resultado será a Décima Posição.

A Décima Primeira posição é realizada a multiplicação a partir da segunda posição do vetor até a posição que foi adicionada que no caso é a posição 10, após realizar as multiplicações respectivas , novamente realiza a soma dos resultados das multiplicações , divide por 11 e o resto da divisão é subtraído pelo número 11 o resultado será a Décima Primeira posição.


----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 5`:

Quinta Questão 

- `Resposta Questão 5`:

Para a realização da Questão 05 era necessário descobrir qual número do vetor seria exibido de acordo com o código. Após a realização do código e sua execução é possível ver que o valor que será exibido é “22”.
