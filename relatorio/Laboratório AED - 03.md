<h1 align="center"> 💻 Laboratório AED - 01 </h1>

## ✔️ Linguagem utilizada
- ``C#``

## 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-PedroHCunhaV).

## 📝 Instruções de Utilização

- `Como Utilizar`:

Ao criar o projeto decidi colocar todas as atividades referentes ao primeiro laboratório em um único arquivo, devido a isso inseri no meu codigo um "do while" para repetir o código e um "switch-case" para escolha qual questão desejar executar.

Como mostrado no print a seguir, é possível ver a solicitação para escolher a questão da atividade: <br>
  ↳Lembrando que o "switch-case" para escolher a questão aceita somente números
![image](https://user-images.githubusercontent.com/101759330/195963146-f8ef0c1d-7cd9-4c5e-b74b-b61af413d00a.png)

Ao final de cada questão é perguntando se deseja repetir o programa com uma resposta de "S/N":<br>
![image](https://user-images.githubusercontent.com/101759330/187083140-d5ada98b-869f-48fd-b3b2-87fa281aaa90.png)

## 🔨 Questões do Laboratório
- `Questão 1`:

Realizar uma Pesquisa Binária utilizando POS

- `Resposta Questão 1`:

Segue Abaixo o print da questão quando é executada:
![image](https://user-images.githubusercontent.com/101759330/195963040-c4016fcf-76ed-4c9d-b612-c441149a23ae.png)

- `Questão 2`:

Realizar uma Pesquisa Binária SEM utilizar POS

- `Resposta Questão 2`:

Segue Abaixo o print da questão quando é executada:<br>
![image](https://user-images.githubusercontent.com/101759330/195963104-e94ff868-cdc6-4584-8f2d-6e3ed97063b6.png)


-`Explicação Questão 1 e 2`:

Vet = 1		3	7	9	10	12

MEIO = INICIO - FIM / 2

INCIO= 0 (Indice)
FIM = Vet.Length

---------------------------------------------------------------------------------

● Caso direita →

	Número que desejo encontrar = 9			Vet = 1		3	7	9	10	12

	↳Solução Lógica

	  *1ºPasso* - Descobrir o Meio do Vetor
	   
		MEIO = INICIO - FIM / 2   → Meio Indice *3* do array(vetor)
		
		FIM = Vetor.Length 	  → Fim Indice *6* do array(vetor)
		INICIO = IndiceVetor(0)   → Inicio = Indice *0* do array(vetor)
	--------------------------------------------------------------------------------------------------------
	  *2ºPasso* - Comparar o Valor do Meio do Vetor

		Se o valor do Meio = 7
		O valor que Desejo = 9
		Então Comparo o Valor que Desejo é Menor que o do Meio?
		9 é Menor que 7? Não
		Caso Não Andarei para a Direita
		Caso Sim Andarei para a Esquerda
	--------------------------------------------------------------------------------------------------------
	  *3ºPasso* - Mudança de Parametros

		Nessa Parte tera que mudar o Meio através de Comparação
		O meio era o 7 mas após perceber que o valor desejado(9) é maior que o meio o meio mudara
		O meio que era o 7 ira virar o inicio
		E o indice do fim mantera o mesmo 
		Sendo feita a conta do meio novamente
		Usando somente a parte direita do vetor

		LADO DIREITO: 7		9	10	12
		
		MEIO: INICIO - FIM / 2  → Nesse caso Seria entre 10 e 9
													
    Assim sendo feita essa divisão de meio ate achar o valor desejado que no caso da questão 1 o valor era : 7 e na questão 2 o valor era:  10

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

Realizar uma Ordenação Binária

- `Resposta Questão 2`:

Ainda em Desenvolvimento (Não Conseguir o Resultado 100% mas ainda estou realizando tentativas)
