**Eart - Rede Social**

**Especificação do caso de uso
Excluir Perfil**

**Histórico da Revisão**

| **Data**   | **Versão** | **Descrição**                              | **Autor**                                                    |
| ---------- | ---------- | ------------------------------------------ | ------------------------------------------------------------ |
| 04/01/2022| 1.0        | Detalhamento do caso de uso Excluir Perfil | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |

**1 Resumo**

Esse caso de uso descreve as etapas percorridas pelo usuário para excluir seu perfil na rede social Eart.

**2 Atores**

Usuário

**3 Pré-condições**

1. Ter um cadastro.

**4 Pós-condições**

1. Ao concluir a ação, o usuário deve ser redirecionado para a página de cadastro.

**5 Fluxos de evento**

**5.1. Fluxo básico**
1. O usuário seleciona os 3 pontinhos na tela de perfil e clica na opção "Excluir perfil";
2. O sistema solicita a senha para confirmar a ação;
3. O usuário informa a senha e aperta em "Sim";
4. O sistema exclui o perfil.

**5.2. Fluxo Alternativo - Não**
1. O usuário seleciona os 3 pontinhos na tela de perfil e clica na opção "Excluir perfil";
2. O sistema solicita a senha para confirmar a ação;
3. O usuário aperta em "Não";
4. O sistema cancela a operação e direciona o usuário para a tela de perfil.

**5.3. Fluxo de exceção 1 - Senha inválida**
1. O usuário seleciona os 3 pontinhos na tela de perfil e clica na opção "Excluir perfil";
2. O sistema solicita a senha para confirmar a ação;
3. O usuário digita uma senha errada;
4. O sistema informa que a senha está errada e solicita que o usuário informe novamente.
