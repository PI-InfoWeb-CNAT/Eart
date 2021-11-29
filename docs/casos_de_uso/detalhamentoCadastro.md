**Eart - Rede Social**

**Especificação do caso de uso
Criar Cadastro**

**Histórico da Revisão**



| **Data**   | **Versão** | **Descrição**                              | **Autor**                                                    |
| ---------- | ---------- | ------------------------------------------ | ------------------------------------------------------------ |
| 14/11/2021 | 1.0        | Detalhamento do caso de uso Criar Cadastro | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |
| 29/11/2021 | 2.0        | Detalhamento do caso de uso Criar Cadastro | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |

**1 Resumo**

Esse caso de uso descreve as etapas percorridas pelo usuário para criar seu cadastro na rede social Eart.

**2 Atores**

Usuário

**3 Pré-condições**

\------

**4 Pós-condições**

1. Ao concluir o cadastro, o usuário deve ser redirecionado para a página de edição de perfil.

**5 Fluxos de evento**

**5.1. Fluxo básico**
1. O usuário entra no sistema;
2. O sistema solicita as informações do usuário;
3. O usuário informa suas informações;
4. O sistema conclui o cadastro.

**5.2. Fluxo Alternativo**

\------

**5.3. Fluxo de exceção 1 - Nome de usuário inválido**
1. O usuário entra no sistema;
1. O sistema solicita as informações do usuário;
3. O usuário digita um nome de usuário que já está em uso;
4. O sistema informa que esse nome de usuário já está em uso e solicita outro.

**5.4. Fluxo de exceção 2 - Email inválido**
   1. O usuário entra no sistema;
   2. O sistema solicita as informações do usuário;
   3. O usuário digita um email que já está em uso;
   4. O sistema informa que esse email já está em uso e solicita outro.

**5.5. Fluxo de exceção 3 - Senha inválida**
1. O usuário entra no sistema;
2. O sistema solicita as informações do usuário;
3. O usuário digita uma senha com menos de 6 caracteres;
4. O sistema informa que a senha deve ter no mínimo 6 caracteres.

**5.6. Fluxo de exceção 4 - Senhas diferentes**
1. O usuário entra no sistema;
2. O sistema solicita as informações do usuário;
3. O usuário digita senhas diferentes nos dois campos em que são solicitadas;
4. O sistema informa ao usuário que as senhas devem ser iguais.

**6 Protótipo(s) de interface do caso de uso**

**Figura 1: protótipo**

![prototipoCadastro](https://user-images.githubusercontent.com/82484797/143931157-be50e82b-537a-403c-b05f-52d51b9e2b88.PNG)
