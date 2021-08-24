# Projeto Rede Social (Trail)

## Especificação do caso de uso - TO COMMENT TRAIL

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 05/06/2021 | **1.00** | Versão Inicial  | Alessandro Souza |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam comentar postagens de trilhas realizadas.

### 2. Atores 

Membros da rede

### 3. Pré-condições

O usuário que vai fazer o comentaŕio precisa estar autenticado no sistema.

### 4.Pós-condições

O sistema deve disponibilizar de forma rápida o comentário realizado na postagem.

### 5. Fluxos de evento

#### 5.1. Fluxo Principal 
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aciona a funcionalidade de comentar postagem sobre a interface gráfica do sistema.||
||2. O sistema apresenta um espaço na interface para capturar o texto do comentário|
|3. O usuário preenche o texto de comentário.||
||4. O sistema grava o comentário acrescentando a data-hora da publicação.|
|5. O usuário visualiza o comentário anexado a referida postagem. ||


#### 5.2. Fluxo de excessão 
     a) Dados inválidos para a operação: caso o usuário tente submeter um comentário sem texto, o sistema deve alertá-lo e solicitar os dados novamente.

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`