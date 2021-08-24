# Projeto Rede Social (Trail)

## Especificação do caso de uso - POST TRAILS

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 05/06/2021 | **1.00** | Versão Inicial  | Alessandro Souza |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam realizar suas postagens de trilhas realizadas.

### 2. Atores 

Membros da rede

### 3. Pré-condições

O usuário que vai fazer a postagem precisa estar autenticado no sistema.

### 4.Pós-condições

O sistema deve disponibilizar de forma rápida as postagens para visualziação.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aciona a funcionalidade de realizar postagem sobre a interface gráfica do sistema.||
||2. O sistema apresenta uma interface para capturar os dados da postagem.|
|3. O usuário preenche as informções de descrição da atividade, imagens, tipo de trilha realizada, distância percorrida, localização e dados do GPS.||
||4. O sistema grava esses dados acrescentando a data-hora da publicação.|
|5. O usuário visualiza sua postagem na lista de postagens. ||


#### 5.2. Fluxo de excessão 
     a) Dados inválidos para a operação: caso o usuário tente submeter uma postagem sem imagens e tipo de trilha, o sistema deve alertá-lo e solicitar os dados novamente.

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`