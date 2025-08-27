# Desafio: Consultor Digital de Planos em Nuvem

Você é um **consultor digital** que ajuda empresas a escolherem o melhor plano de serviços na nuvem.  
Com base nas necessidades do cliente, seu programa deve recomendar o plano adequado.

## Entrada

O programa deve receber uma **string** representando o tipo de serviço desejado:

- `basico`
- `intermediario`
- `avancado`
- `premium`

## Saída

O programa deve retornar uma string com a recomendação:

- `Recomendado: plano basico`
- `Recomendado: plano intermediario`
- `Recomendado: plano avancado`

Observação: caso a entrada seja `premium`, o programa deve recomendar o **plano avancado**.

## Exemplos

| **Entrada**   | **Saída esperada**               |
| ------------- | -------------------------------- |
| basico        | Recomendado: plano basico        |
| intermediario | Recomendado: plano intermediario |
| avancado      | Recomendado: plano avancado      |
| premium       | Recomendado: plano avancado      |

---

_Desafio criado para praticar lógica de programação e manipulação de strings em C#. Certifique-se de testar outros cenários além dos exemplos fornecidos._
