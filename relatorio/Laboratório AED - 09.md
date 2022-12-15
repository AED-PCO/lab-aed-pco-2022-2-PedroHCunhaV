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
![image](https://user-images.githubusercontent.com/101759330/207856453-1763c683-1656-447e-bba3-c53f85b6b0b3.png)

Ao final de cada questão é perguntando se deseja repetir o programa com uma resposta de "S/N":<br>
![image](https://user-images.githubusercontent.com/101759330/187083140-d5ada98b-869f-48fd-b3b2-87fa281aaa90.png)

## 🔨 Questões do Laboratório
- `Questão 1`: 

Atividade Referente a Cópiar de uma Pilha para Outra

- `Resposta Questão 1`:

Para a realização de uma Pilha Copiada que possua os mesmos valores que a Pilha Original de maneira Estática, foi criado dois vetores um para a Pilha Original e outro Vetor para a Pilha Copiada ambos com tamanho igual a 5. Foi realizada uma função para inserção de valores aleatórios ao vetor da Pilha Original, isso foi possível utilizando o Random e adicionando os números através de um for para cada posição do vetor. Após Inserir os valores ao vetor Pilha Original é exbido os valores atuais que possuem nos vetores Pilha Original e Pilha Copiada, a Pilha Original possuira valores aletórios para cada posição e o vetor Pilha Original apresentará todas suas posições vazias como no print (Antes de Copiar) , após realizar essa exibição/impressão é perguntando se deseja realizar a cópia de uma pilha para outra caso responda "S ou s" é realizada a cópia através de um for que ira percorrer a Pilha Original e em cada posição da Pilha Original e adicionada a posição respectiva na Pilha Copiada, após realizar essa cópia é exibido/imprimido na tela os dois vetores novamente para mostrar que foi raizada a cópia como mostrado no print (Depois de Copiar).

# Antes de Copiar
![image](https://user-images.githubusercontent.com/101759330/207856929-baad40eb-f0c7-427b-8171-8670bfe3cf4b.png)

# Depois de Copiar
![image](https://user-images.githubusercontent.com/101759330/207856993-a7efc07f-02a4-4435-b293-579e75bd450f.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

Atividade Referente a Copiar de uma Fila para Outra Invertendo a Ordem 

- `Resposta Questão 2`:

Para a realização de uma Fila Copiada que possua os mesmos valores que a Fila Normal só que apresente os valores de modo inverso, foi criado dois vetores um para a Fila Normal e outro para Fila Inversa ambos com tamanho igual a 5. Foi realizada uma função para inserção de valores de acordo com o tamanho do vetor nesse caso sera inserido os valores (1,2,3,4,5), após realizar a inserção é realizada a impressão do Vetor Normal na tela para ser possível saber os números e a ordem do vetor antes da realização dos outros processos. Logo depois de realizar esssa exibição/impressão é perguntado se deseja realizar a copia e inversão do Vetor Normal caso responda "S ou s" é realizada a cópia através de uma função de Inversão onde realiza uma remoção em fila para realizar a cópia dos valores e uma remoção em pilha que será realizada a inversão dos valores e após isso é realizada a exibição/impressão do Vetor Normal e do Vetor Inverso através da função de Visualização que realiza a leitura e exibição dos dados através de um for lendo cada posição do vetor.

![image](https://user-images.githubusercontent.com/101759330/207872148-bc244e6d-9cf5-41ef-aea1-c00911203e70.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Copiar uma lista para outra lista(metade com a ordem normal da lista original e metade com a ordem inversa)

- `Resposta Questão 3`:

Para a realização de uma Lista que possua Metade de Acordo com uma Lista e outra metade de Acordo com a Lista só que o inverso, foi criado três vetores o primeiro é a ListaOriginal onde sera inseridos os dados , o segundo é a ListaCopiada onde sera copiada os valores da ListaOriginal e serão invertidos, a terceira é a ListaCompleta que sera o conjunto da ListaOriginal(ordem normal) e  da ListaCopiada(os mesmo valores ao inverso). Os vetores ListaOriginal e ListaCopiada possuem um tamanho de 5 e a ListaCompleta possui um tamanho de 10 para que fosse possível armazenar o valor dos outros dois vetores(cada um possui 5). Para inserção dos valores na ListaOriginal foi realizada um função que utiliza o Random para inserir valores aleatórios , isso é possível com a utilização de for para inserir em cada posição do vetor.A inversão dos valores é relaizado através de um for onde pego a última posição do vetor e vou atribuindo a ListaCopia e reduzindo minha variavael de controle até o tamanho do vetor acabar. Após isso realizo a leitrua do vetor ListaOriginal e adiciono nas 5 primeiras posições do vetor ListaCompleta e depois a leitura do vetor ListaCopiada e adiciona nos outros cincos espaços disponiveis do veotr ListaCompleta.Após essas realizações é exibido o vetor ListaCompleta na tela.

![image](https://user-images.githubusercontent.com/101759330/207876732-ec61c4e8-c291-4613-b560-51a16e9ff14b.png)

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

