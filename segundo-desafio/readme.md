# Desafio

Você é um consultor digital que ajuda empresas a otimizar seus serviços na nuvem.  
Seu cliente precisa de um relatório que exiba a quantidade total de interações com seus serviços ao longo de um período.  
Cada interação é registrada em uma lista e você deve calcular o total com base em um número de dias informado.

## Entrada

A entrada deve receber uma string contendo:

- um número inteiro que representa a quantidade de dias,
- em seguida, uma lista de interações, onde cada interação é uma string contendo um identificador único.

As interações devem ser separadas por espaço.

_Exemplo:_  
7 id1 id2 id3 id4 id5 id6 id7

## Saída

Deverá retornar uma string com a quantidade total de interações registradas, seguida da palavra **interacoes**.

_Exemplo:_  
7 interacoes

## Exemplos

| Entrada               | Saída        |
| --------------------- | ------------ |
| 3 id1 id2 id3         | 3 interacoes |
| 5 id1 id2 id3 id4 id5 | 5 interacoes |
| 2 id1 id2             | 2 interacoes |

---

_Atenção:_ É extremamente importante que as entradas e saídas sejam exatamente iguais às descrições do desafio de código.
