# Projeto Rede Social (Eart)

## Detalhamento do caso de uso - Criar perfil

### Histórico da Revisão: 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 09/07/2021 | **`1.0`** | Versão Inicial  | Alexsander Anulino, Aristóteles Daniel, Marcos Vinícius, Mariana Raquel, Viviane Pereira |

### 1. Resumo: 

Este caso de uso permite que os visitantes possam criar sua conta na rede social.

### 2. Atores: 

Visitantes.

### 3.Pós-condições:

O sistema deve disponibilizar de forma rápida o cadastro no sistema.

### 4. Fluxos de evento:

#### 4.1. Fluxo Principal:
|  Ator  | Sistema |
|:-------|:------- |
| 1. O usuário aciona a funcionalidade de fazer cadastro na interface gráfica do sistema. ||
|| 2. O sistema apresenta um espaço na interface para registrar os dados do usuário (nome, email e senha). |
| 3. O usuário preenche seus dados. ||
|| 4. O sistema grava os dados do usuário no sistema e registra sua conta. |
| 5. Após a conta ser registrada, o usuário visualiza a tela inicial do site. ||

#### 4.2. Fluxo de excessão: 
    a) Email inválido: caso o usuário tente submeter um email já registrado, o sistema deve alertá-lo e solicitar um novo email.
    b) Senha inválida: caso o usuário tente submeter uma senha com menos de 8 dígitos, o sistema deve alertá-lo e solicitar a senha novamente.

### 5. Prototipos de Interface:

`Em desenvolvimento.`