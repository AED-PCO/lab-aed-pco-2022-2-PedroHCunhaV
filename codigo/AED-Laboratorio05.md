<h1 align="center"> 💻 Laboratório AED - 05 </h1>

## ✔️ Exercícios de Complexidade

## 🔨 Questões do Laboratório
- `Questão 1`:

![image](https://user-images.githubusercontent.com/101759330/195962593-8847a042-235d-436d-b98f-c05cc2ec601d.png)

- `Resposta Questão 1`:

public int alg1(int n){ <br>
	int res = 1;	<br>
	for(int i=n;i>1;i- -){      → (N-1) <br>
   res = res*i;        → (1) <br>
  } <br>
} <br>

(N-1) * 1 = N - 1


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 2`:

![image](https://user-images.githubusercontent.com/101759330/195962660-63e55b1c-92d2-4bef-bda9-890dd4ffee20.png)

- `Resposta Questão 2`:

public int alg2(int[] arr, int x){ <br> 
	for(int i=0;i<arr.length;i++){   → N (N vezes roda o vetor) <br>
		 if(arr[i] == x) return x;	→ 1 <br>
 } <br>
 return -1; <br>
} <br>

N * 1 = N

----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 3`:

![image](https://user-images.githubusercontent.com/101759330/195962712-a5c83545-225b-4d54-a3e2-e18f2fd94616.png)

- `Resposta Questão 3`:

double[] alg3 (double []arr1){ <br>
  double[] res; <br>
	 for(int pos = 0 ; pos<arr1.lenght ; pos++){ → (N) <br>
		  for(int j= 0; j < arr1.length; j ++){  → (N) <br>
	      if(j!=pos){  → (1) <br>
     (1) ← res[pos] += arr1[pos]/arr1[j] → (1) <br>
        } <br>
      } <br>
    } <br>
  } <br>
  
N * N * (1+1+1) = 3N^2


----------------------------------------------------------------------------------------------------------------------------------------------------------------------

- `Questão 4`:

![image](https://user-images.githubusercontent.com/101759330/195962762-b0ae80e1-2a6c-4f20-aea7-8e08229f4c29.png)

- `Resposta Questão 4`:

public double [] alg4 (int[] dados){ <br>
	double[] vet = new double[dados.length]; <br>
	for(int = 0; i < dados.length; i ++) { → (N) <br>
		  double soma = 0.0; <br>
		  for(int j = 0; j <= dados.length; i++){ →(N) <br>
	     soma+=dados[j]; → (1) <br>
     } <br>
    (1)← vet[i] = soma/(i+1); → (1) <br>
   } <br>
	return vet;	 <br>
} <br>


N*N * (1+1+1) = 3N^2

