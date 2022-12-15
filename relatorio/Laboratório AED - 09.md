<h1 align="center"> 💻 Laboratório AED - 09 </h1>

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

# Inserção
![image](https://user-images.githubusercontent.com/101759330/207335827-27afbae6-0edd-459f-ac9e-3950826899d2.png)

# Remoção
![ada](https://user-images.githubusercontent.com/101759330/207337679-dfeeb800-2551-46fa-ae88-aa3db294d4fc.png)

# Visualização
![aba](https://user-images.githubusercontent.com/101759330/207338246-1e526e3b-a51c-42f3-8ece-7f024dea5ce6.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Atividade Referente a utilização de Pilha Estática

- `Resposta Questão 2`:

Para a realização da Pilha Estática e suas ações (inserir,remover e visualizar), realizei a criação do vetor de tamanho 5 e de uma variavel que será utilizada para saber as posições e o tamanho máximo do vetor. Foi realizado um menu de seleção para que o usuário escolha qual ação ele deseja realizar, esse menu foi realizado através de um do-while para que quando o usuário realizasse uma ação ele pudesse repetir a ação ou escolher outra. Dentro do do-while possui um switch case que cada caso chama a função de cada ação(Inserir,Remover e Visualizar).Para Inserir os valores no vetor foi realizado a criação de uma função onde passa como parametros o vetor e a variavel de parametro de tamanho, nessa função possui um if para saber se o vetor ja esta preenchido caso já esta preenchido não é possível realizar a inserção, caso não esteja cheio solicita que o usuário digite o valor que deseja inserir e o mesmo lê o valor na primeira posição disponivel.Para a função de remover da pilha foi utilizada uma variavel auxiliar para armazenar o valor e a ultima posição que logo após é retirada pois na pilha o último item da pilha é o primeiro a ser retirado.A função para Visualizar foi feita através de um for onde o mesmo verificar em cada posição do vetor se a mesma esta preenchida se tiver preenchida ele imprime o valor que esta na posição caso não esteja preenchida exibe como vazia, através do for isso é realizado em cada posição do vetor de acordo com o seu tamanho.

![image](https://user-images.githubusercontent.com/101759330/207344473-96e84f16-1805-4fcd-9e90-f3b665e58f05.png)

# Inserção
![image](https://user-images.githubusercontent.com/101759330/207335827-27afbae6-0edd-459f-ac9e-3950826899d2.png)

# Remoção
![aca](https://user-images.githubusercontent.com/101759330/207349355-80dc0be8-d343-44e0-b44d-669b49c46102.png)

# Visualização
![aba](https://user-images.githubusercontent.com/101759330/207338246-1e526e3b-a51c-42f3-8ece-7f024dea5ce6.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Atividade Referente a utilização de Lista Estática

- `Resposta Questão 3`:

Para a realização da Fila Estática e suas ações (inserir,remover e visualizar), realizei a criação do vetor de tamanho 5 e de uma variavel que será utilizada para saber as posições e o tamanho máximo do vetor. Foi realizado um menu de seleção para que o usuário escolha qual ação ele deseja realizar, esse menu foi realizado através de um do-while para que quando o usuário realizasse uma ação ele pudesse repetir a ação ou escolher outra. Dentro do do-while possui um switch case que cada caso chama a função de cada ação(Inserir,Remover e Visualizar).Para Inserir os valores no vetor foi realizado a criação de uma função onde passa como parametros o vetor e a variavel de parametro de tamanho, nessa função possui um if para saber se o vetor ja esta preenchido caso já esta preenchido não é possível realizar a inserção, caso não esteja cheio solicita que o usuário digite o valor que deseja inserir e o mesmo lê o valor na primeira posição disponivel , caso a posição esteja disponível é perguntado se deseja escolher a posição que sera inserida o valor desejado, caso deseje escolher a posição para inserção é inserido na posição desejada caso a mesma não exceda uma posição disponivel, caso exceda a mesma ajusta aonde sera inserido, se não escolher onde deseja inserir é inserido na primeira posição disponivel.Para a função de remover da lista foi utilizado um if-else para verificar se a lista não esta vazia seleciona uma posição que deseeja remover e verifica se a posição escolhida é valida caso seja valida  e realizada a remoção. A função para Visualizar foi feita através de um for onde o mesmo verificar em cada posição do vetor se a mesma esta preenchida se tiver preenchida ele imprime o valor que esta na posição caso não esteja preenchida exibe como vazia, através do for isso é realizado em cada posição do vetor de acordo com o seu tamanho.

# Inserção
![image](https://user-images.githubusercontent.com/101759330/207357126-f80223e9-dcfd-4090-adc7-b1bf7058985b.png)

# Remoção
![image](https://user-images.githubusercontent.com/101759330/207357225-d3b4cae1-fea3-40b5-ba4f-dd5dce0b334f.png)

# Visualização
![aba](https://user-images.githubusercontent.com/101759330/207338246-1e526e3b-a51c-42f3-8ece-7f024dea5ce6.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

