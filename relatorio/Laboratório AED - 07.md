<h1 align="center"> 💻 Laboratório AED - 06 </h1>

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

Utilize o metodo do Bubblesort para organizar um array

- `Resposta Questão 1`:

Para a realização do método de ordenagem Bubble Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado. Após isso, criei uma variável auxiliar para realizar a troca de posições no vetor e criei dois “for” um inserido dentro do outro para fazer o percurso de cada posição do vetor. No “for” de dentro possui um “ if ” para fazer a comparação da posição atual com a próxima e caso atual seja maior que a próxima realiza a troca.

Segue Abaixo o print da questão quando é executada:
![Cópia de LAB6 - 01](https://user-images.githubusercontent.com/101759330/197059753-d730db4f-4592-453a-8479-261d360b5c18.png)

- `Gráfico Questão 1`:

![image](https://user-images.githubusercontent.com/101759330/197062141-94bc56c3-2234-42a4-8303-d14963251c96.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Utilize o metodo do SelectionSort para organizar um array

- `Resposta Questão 2`:

Para a realização do método de ordenagem Selection Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado.  Após isso, criei uma variável chamada “ menor “ onde a mesma vai armazenar o menor valor das posições do vetor e outra variável auxiliar para realizar a troca dos valores. Para saber o valor que está inserido em cada posição do vetor realizei a criação de dois “ for “ um inserido dentro do outro. No “ for “ de dentro verifica se a posição do vetor é a menor caso seja atribui o valor da posição a variável menor. No “for” de fora é realizado a troca das posições com utilização da variável auxiliar.


Segue Abaixo o print da questão quando é executada:<br>
![LAB6 - 02](https://user-images.githubusercontent.com/101759330/197060509-55284aa2-cded-456b-a73d-6a092374e8bd.png)

- `Gráfico Questão 2`:

![image](https://user-images.githubusercontent.com/101759330/197062074-13a140d7-761e-46be-ba27-8174c4a07dd8.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Utilize o metodo do InsertionSort para organizar um array

- `Resposta Questão 3`:

Para a realização do método de ordenagem Selection Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado.  Após isso, criei uma variável chamada “ flag “ que ao inserir um valor saber o tamanho de vetor como um método de parada e uma outra variável auxiliar que realizará as trocas de posições.Para saber o valor que está inserido em cada posição do vetor realizei a criação de dois “ for “ um inserido dentro do outro.No “for” de dentro possui um “if” onde é feita a comparação e troca de posições com a utilização da variável auxiliar , também possui um ”else” onde é usado a variável “flag” para não ultrapassar o tamanho do vetor.

Segue Abaixo o print da questão quando é executada:<br>
![LAB6 - 03](https://user-images.githubusercontent.com/101759330/197060760-56c969eb-b017-4b87-b8be-d5efa2a82495.png)

- `Gráfico Questão 3`:

![image](https://user-images.githubusercontent.com/101759330/197062016-fcf938af-2269-4218-ba19-24a56345008d.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

Utilize o metodo do QuickSort para organizar um array

- `Resposta Questão 4`:

Para a realização do método de ordenagem Quick Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado.Após isso criei duas funções uma chamada “Partição” onde será feita a comparação com o pivô que determinará as trocas de posições e outra chamada “Quick” que verifica o valor do pivô.

Segue Abaixo o print da questão quando é executada:<br>
![LAB6 - 04](https://user-images.githubusercontent.com/101759330/197061004-66968d24-aceb-409e-99d6-17e460175855.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 5`:

Utilize o metodo do ShellSort para organizar um array

- `Resposta Questão 5`:

Para a realização do método de ordenagem Shell Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado.A lógica utilizada nesse exercicio foi feita atraves de um while para realizar os pulos (hop) e ir organizando as posições de acordo com o tamanho do hop que foi dado com o passar das execuções.

Segue Abaixo o print da questão quando é executada:<br>
![LAB6 - 05](https://user-images.githubusercontent.com/101759330/197061138-c841a7d5-39ab-476d-84f5-ec843921e257.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 6`:

Utilize o metodo do ContagemSort para organizar um array

- `Resposta Questão 6`:

Para a realização do método de ordenagem Contagem Sort criei um vetor random para  ter uma variedade de números. Após a criação do vetor desordenado imprime o mesmo na tela para ter um controle se o vetor será mesmo ordenado.Após isso criei duas funções uma chamada “Contagem” onde será realizada a contagem de repetições de um mesmo valor no vetor e a organização de suas posições e outra chamada “MaxVal” que verifica maior valor desse vetor para determinar suas respectivas posições.

Segue Abaixo o print da questão quando é executada:<br>
![LAB6 - 06](https://user-images.githubusercontent.com/101759330/197061335-c00513ed-433c-4bba-9098-985ec72e51a5.png)
