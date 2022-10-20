<h1 align="center"> 💻 Laboratório AED - 01 </h1>

## ✔️ Linguagem utilizada
- ``C#``

## 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-PedroHCunhaV).

## 📝 Instruções de Utilização

- `Como Utilizar`:

Ao criar o projeto decidi colocar todas as atividades referentes ao primeiro laboratório em um único arquivo, devido a isso inseri no meu codigo um "do while" para repetir o código e um "switch-case" para escolha qual questão desejar executar.

Como mostrado no print a seguir, é possível ver a solicitação para escolher a questão da atividade:
![image](https://user-images.githubusercontent.com/101759330/187083004-bf41c046-36ed-473d-bb6d-6e2e356e4622.png)

Lembrando que o "switch-case" para escolher a questão aceita somente números como no exemplo abaixo:
![image](https://user-images.githubusercontent.com/101759330/187083059-d9a55c13-6daf-4a39-92f9-ceefc195396e.png)

Ao final de cada questão é perguntando se deseja repetir o programa com uma resposta de "S/N":<br>
![image](https://user-images.githubusercontent.com/101759330/187083140-d5ada98b-869f-48fd-b3b2-87fa281aaa90.png)

Caso deseje repetir o Programa o mesmo solicita novamente a escolha da questão para ser possível o acesso as outras questões:
![image](https://user-images.githubusercontent.com/101759330/187083207-2a0fb47f-e993-48a8-8a3f-8588666f61f5.png)


## 🔨 Questões do Laboratório
- `Questão 1`:

Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.

- `Resposta Questão 1`:

Para a realização dessa questão utilizei o comando "for" para ser possivel realizar a repetição do comando até chegar ao núemro desejado que nesse caso é de 1000 a 9999. Dentro do comando "for" realizei a divisão do meu número para conseguir cada parte do valor separado como 30 e 25 dito na questão, realizando a divisão e colocando duas variáveis uma para o resto da divisão e outra para o resultado sendo assim possível dividir o número em duas partes.Após isso realizei a soma do resultado e do resto da divisão e multiplicando essa soma por si mesma.Logo após verifiquei se o valor dessa multiplicação é o número que esta sendo utilizado no momento caso fosse o mesmo seria apresentado na tela.

![image](https://user-images.githubusercontent.com/101759330/187083394-0f09c95c-373a-4288-8648-fddbbb226abd.png)

Segue Abaixo o print da questão quando é executada:
![image](https://user-images.githubusercontent.com/101759330/187083344-2e8bcb54-5229-4f81-b333-cbbeb44fb3aa.png)

- `Gráfico Questão 1`:

![image](https://user-images.githubusercontent.com/101759330/196980967-e97946da-4e03-4ac6-867e-8173513b4a4c.png)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo.

- `Resposta Questão 2`:

Realizei a questão com a utilização de um "for" para verificar se o resto da divisão do número pelo contador vai dar igual a zero e assim somando mais um valor a variável "cont" , que logo após a mesma variável é utilizada para verificar se o número é primo ou não.

Segue Abaixo o print da questão quando é executada:

Não sendo Primo<br>
![image](https://user-images.githubusercontent.com/101759330/187112837-6dd2435a-d943-4405-afec-a4d0f7fec906.png)

Sendo Primo<br>
![image](https://user-images.githubusercontent.com/101759330/187112946-e2dd88ba-a24d-4ccc-a870-723e17cd1899.png)

- `Questão 2 - Parte 2`:

Realizei a questão utilizando um "while" para fazer o calculo de numero perfeitos dentro do intervalo de 1 a 1000. Dentro do mesmo é realizada a verificação dos divisores dos números através de um "for" e adicionando e somando os divisores na variável "soma" , logo após verifico com um "if" se as soma dos divisores é igual ao número utilizado.

Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.


Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187113021-16938082-1110-4ad4-8f66-4cd81aaef1a5.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

- `Resposta Questão 3`:

Ao realizar essa questão permitir para que o usuário utilizando o programa determine os valores dos vetores A e B. Para verificar e realizar os vetores C e D utilizei um "for" para passar em todos elementos do vetor e dentro desse mesmo "for" a utilização de um for para verificar em qual vetor o valor deve estar.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187114138-b756337f-dc10-4f43-af17-2c3e9ba61b1d.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

- `Resposta Questão 4`:

Ao realizar essa questão permitir para que o usuário utilizando o programa determine os valores da matriz. Utilzei dois "for" um para linha e outra para coluna realizando a soma das mesmas e adicionando a uma variável, após isso com a utilização de "for" realizo a impressão da resposta.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187114838-491c53bd-e8a2-4df0-8cc5-4d1a446ed12c.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 5`:

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro

- `Resposta Questão 5`:

Nessa questão utilzei o "while" para verificar o fatorial do número digitado pelo usuário e dentro do mesmo "while" utilzei a formula do fatorial.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187115341-9ff21f7b-234d-4338-8ed8-639a19c78dcb.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 6`:

Faça um programa que chame sua função capaz de calcular x elevado a y, sendo x e y inteiros. Utilize passagem de parâmetros por referência.

- `Resposta Questão 6`:

Como solocitado na questão realizei a função para fazer a elevação do número através de um "Math.Pow" e passei os resultados para impressão através de referência.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187116288-efdb944a-02d2-4921-b91d-d615b8d6e074.png)
