**Eart - Rede Social**

**Especificação do caso de uso
Fazer Login**

**Histórico da Revisão**



| **Data**   | **Versão** | **Descrição**                              | **Autor**                                                    |
| ---------- | ---------- | ------------------------------------------ | ------------------------------------------------------------ |
| 29/11/2021 | 1.0        | Detalhamento do caso de uso Fazer Login | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |

**1 Resumo**

Esse caso de uso descreve as etapas percorridas pelo usuário para fazer login na rede social Eart.

**2 Atores**

Usuário

**3 Pré-condições**

1. O usuário deve ter um cadastro.

**4 Pós-condições**

1. Ao concluir o cadastro, o usuário deve ser redirecionado para a página de publicações em alta.

**5 Fluxos de evento**

**5.1. Fluxo básico**
1. O usuário entra no sistema;
2. O sistema solicita as informações do usuário;
3. O usuário informa suas informações;
4. O sistema efetua o login.

**5.2. Fluxo Alternativo**

\------

**5.3. Fluxo de exceção 1 - Nome de usuário inválido**
1. O usuário entra no sistema;
1. O sistema solicita as informações do usuário;
3. O usuário informa um nome de usuário que não está cadastrado no sistema;
4. O sistema informa a mensagem “Este usuário não existe” e solicita as informações novamente.

**5.4. Fluxo de exceção 4 - Senha errada**
1. O usuário entra no sistema;
2. O sistema solicita as informações do usuário;
3. O usuário informa uma senha diferente da correspondente ao nome de usuário;
4. O sistema informa a mensagem “Senha incorreta” e solicita as informações novamente.

**6 Protótipo(s) de interface do caso de uso**

**Figura 1: protótipo**

![prototipoLogin](https://user-images.githubusercontent.com/82484797/143934328-9537a88e-2f84-4724-8202-dd2ff3dc0557.PNG)
