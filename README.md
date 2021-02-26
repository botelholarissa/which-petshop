# which-petshop

Aplicação em C# com o objetivo de escolher entre 3 opções qual é o PetShop com o valor mais barato e em caso de empate o Petshop mais próximo do cliente. 

## O Problema:
Senhor Eduardo é proprietário de um canil em Belo Horizonte, ele trabalha com diversas raças, pequenas e grandes. Eduardo gosta que seus cães estejam sempre arrumados, felizes e
cheirosos. No bairro do canil, para realizar o banho nos animais, existem três petshops: Meu Canino Feliz, Vai Rex, e ChowChawgas. Cada um deles cobra preços diferentes para banho em cães
pequenos e grandes e o preço pode variar de acordo com o dia da semana.

● Meu Canino Feliz: Está distante 2km do canil. Em dias de semana o banho para cãespequenos custa R$20,00 e o banho em cães grandes custa R$40,00. Durante os finais de semana o preço dos banhos é aumentado em 20%.  
● Vai Rex: Está localizado na mesma avenida do canil, a 1,7km. O preço do banho para dias úteis em cães pequenos é R$15,00 e em cães grandes é R$50,00. Durante os finais de semana o preço para cães pequenos é R$ 20,00 e para os grandes é R$ 55,00.  
● ChowChawgas: Fica a 800m do canil. O preço do banho é o mesmo em todos os dias da semana. Para cães pequenos custa R$30 e para cães grandes R$45,00.  

Apesar de se importar muito com seus cãezinhos, Eduardo quer gastar o mínimo possível. Desenvolva uma solução para encontrar o melhor petshop para levar os cães. O melhor petshop será o que oferecer menores preços, em caso de empate o melhor é o mais próximo
do canil.

## Premissas

O projeto deve ser desenvolvido na linguagem C# e bibliotecas nativas,  
Foi usado o editor (Visual Studio): [https://visualstudio.microsoft.com/pt-br/vs/community/],  
Tempo de realização de até 3 dias.

## Decisões de projeto:

Optei por criar 2 Classes Petshop.cs e Pedido.cs:  
- A classe Petshop foi usada para manipular os dados dos Petshops que foram propostos no problema fazer o cálculo do valor total do Pedido.  
- A classe Pedido para criar um novo pedido baseando-se na entrada de dados de data e da quantidade de cães grandes e pequenos. 

Fiz métodos para fazer a **leitura da quantidade de cães**, **leitura do dia da semana** e **fazer o cálculo** do valor total dos banhos utilizando o método CalcularPEdido, lista qual é o menor valor (caso haja empate, qual o petshop mais próximo) e 
retorna a lista para o método que **exibe o orçamento final**.


## Como executar: 

```powershell
# Clone este repositório
$ git clone https://github.com/botelholarissa/which-petshop.git
# Acesse a pasta do projeto no terminal/cmd
$ cd which-petshop
```
Abra o arquivo EscolhaPetshop.sln utilizando o Visual Studio e builde o projeto EscolhaPetshop.

```powershell  
Bora levar os doguinhos para tomar um banho?  
Digite a data no formado dd/mm/aaaa:  
<data>  
Escreva a quantidade de cães pequenos:  
<qtd de cães pequenos>  
Escreva a quantidade de cães grandes:  
<qtd de cães grandes>  

O PetShop mais em conta para o dia escolhido é o {petshop} e o valor total é R${valor}.

```
