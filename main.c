#include <stdio.h>
#include <stdlib.h>
int main(){
		float valor[100], vtotal,desconto, vbase,vfinal, percentual[100];
		int area,quantidade[100],cont,cont2, i;
		char nome[100][100],resposta;
		printf("Escolha a area do produto: \n");
		printf("1. Informatica \n");
		printf("2. Jogos \n");
		printf("3. Eletronicos \n");
		scanf("%d", &area);
		switch(area){
		case 1:
			cont=0;
			printf("Voce escolheu a area informatica: \n");
			do {
				printf("Digite o nome do produto desejado: \n");
				scanf("%s", &nome[cont]);
				printf("Digite a quantidade desejada: \n");
				scanf("%d",&quantidade[cont]);
				printf("Digite o valor do produto: \n");
				scanf("%f", &valor[cont]);
				percentual[cont] = 0.05;
				printf("Deseja cadastrar mais produtos? s/n \n");
				scanf("%s", &resposta);
				cont++;
			}while(resposta != 'n');
			break;
		case 2:
			printf("Voce escolheu a area Jogos: \n");
			do{
				printf("Digite o nome do produto desejado: \n");
				scanf("%s", &nome[cont]);
				printf("Digite a quantidade desejada: \n");
				scanf("%d",&quantidade[cont]);
				printf("Digite o valor do produto: \n");
				scanf("%f", &valor[cont]);
				percentual[cont] = 0.05;
				printf("Deseja cadastrar mais produtos? s/n \n");
				scanf("%s", &resposta);
				cont++;
			}while(resposta != 'n');
			break;
		case 3:
			printf("Voce escolheu a area Eletronicos: \n");
			do{
			scanf("%s", &nome[cont]);
				printf("Digite a quantidade desejada: \n");
				scanf("%d",&quantidade[cont]);
				printf("Digite o valor do produto: \n");
				scanf("%f", &valor[cont]);
				percentual[cont] = 0.05;
				printf("Deseja cadastrar mais produtos? s/n \n");
				scanf("%s", &resposta);
				cont++;
			}while(resposta != 'n');
			break;
		default:
			printf("Area invalida! \n");
		}
		cont2 = cont--;
		for(i = 0; i <= cont; i++ ){
			vbase = quantidade[i]*valor[i];
			desconto = vbase*percentual[i];
			vtotal = vbase-desconto;
			printf("Voce comprou o produto: %s \n",nome[i]);
			printf("A quantidade solicitada foi: %d \n", quantidade[i]);
			printf("O valor unitario do produto eh: %f", valor[i]);
			printf("O percentual de desconto eh: ", percentual[i]);
			printf("O valor base dos produtos eh: %f", vbase);
			printf("O valor do desconto eh: %.2f \n", desconto);
			printf("O valor final com desconto eh: %.2f \n", vtotal);
			printf("\n");
			
			vfinal = vfinal + vtotal;
		}
		printf("A soma de todos os produtos eh: %f",vfinal );
}

