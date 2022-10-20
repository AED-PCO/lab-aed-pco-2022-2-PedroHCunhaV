<h1 align="center"> 💻 Laboratório AED - 02 </h1>

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

Escreva um método recursivo que retorne o fatorial de um número.

- `Resposta Questão 1`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo que multiplica o número pelo método recursivo "Fatorial" e subtraindo -1 ao número.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187118093-4e7162d6-e0c5-4fe1-9d38-39d3a1198cbe.png)

- `Gráfico Questão 1`:

![image](https://user-images.githubusercontent.com/101759330/196986739-ec1b813a-92ea-418a-b7f3-7271b2f811f7.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Uma multiplicação pode ser vista como uma sequência de somas. Escreva um método recursivo que realize a multiplicação de dois números inteiros, A e B, recebidos por 
parâmetro.

- `Resposta Questão 2`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo retornando o segundo valor digitado. No "else" desse mesmo "if" realizo a parte recursiva somando o primeiro valor ao método recursivo passando como parâmetro os primeiro valor e o segundo valor -1 para ser possível a realização da multiplicação dos números.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187118351-fa16ff9f-5761-44b5-8a3f-53cca52fef9d.png)

- `Gráfico Questão 2`:

![image](https://user-images.githubusercontent.com/101759330/196989317-63c95a8b-1db1-4226-8597-5531d2f3f994.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Escreva um método recursivo que realize a potenciação entre dois números inteiros, A e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado 
de AB

- `Resposta Questão 3`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo verificando se o valor da potência e igual a 0 e retornando 1. No "else" deste mesmo "if" é realizada o método recursivo desta maneira (return A * Potencia(A, B - 1);)

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187118866-c594856b-5660-4fe3-a7e2-95c64c38dd1b.png)

- `Gráfico Questão 3`:

![image](https://user-images.githubusercontent.com/101759330/196990339-2084f056-180d-4e5e-9696-8e422cbe8e4d.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

- `Resposta Questão 4`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo e no else do if realizei a condição para andar no array e retirar a letra(char) desejado pelo usuário.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/190523974-158f0600-d345-4e58-ab24-7fc157dc6e02.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 5`:

Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.

- `Resposta Questão 5`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo com o tamanho do vetor como verificação. No "else" deste mesmo "if" é realizada o método recursivo ao pegar o tamanho do vetor e ir passando por cada elemento de trás para frente e diminuindo por 2 para achar o valor par num vetor ordenado de 1 a 10.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187119494-50bd0cac-06ce-4bc4-828b-1218fce20d08.png)

- `Gráfico Questão 5`:

![image](https://user-images.githubusercontent.com/101759330/196991227-9d8bd788-55d8-4388-94e2-697a5498ff6e.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 6`:

Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal.

- `Resposta Questão 6`:

Realizei nessa questão a utilização de um "if" para conferir as vogais da frase/palavra e usando o array resize para retirar a vogal do vetor e arrumar o tamanho do mesmo caso não fosse uma vogal na posição que esta lendo ele vai ir para a próxima.

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/190523608-109b8987-cca8-4962-a498-8fa0b16744bc.png)


----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 7`:

Definição recursiva da série de Fibonacci.

- `Resposta Questão 7`:

Realizei nessa questão a utilização de um "if" como parada para o método recursivo utilizando o valor digitado como verificação. No "else" deste mesmo "if" é realizada o método recursivo desta maneira (return Fibonacci(valor - 1) + Fibonacci(valor - 2);)

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/187119964-be47e3bf-07b4-4931-9c1a-2f90611f2029.png)



