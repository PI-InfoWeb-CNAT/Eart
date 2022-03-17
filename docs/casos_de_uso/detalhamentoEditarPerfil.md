**Eart - Rede Social**

**Especificação do caso de uso
Editar Perfil**

**Histórico da Revisão**

| **Data**   | **Versão** | **Descrição**                              | **Autor**                                                    |
| ---------- | ---------- | ------------------------------------------ | ------------------------------------------------------------ |
| 29/11/2021 | 1.0        | Detalhamento do caso de uso Editar Perfil | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |

**1 Resumo**

Esse caso de uso descreve as etapas percorridas pelo usuário para editar seu perfil na rede social Eart.

**2 Atores**

Usuário

**3 Pré-condições**

1. Ter um cadastro.

**4 Pós-condições**

1. Ao concluir a edição, o usuário deve ser redirecionado para a página de perfil.

**5 Fluxos de evento**

**5.1. Fluxo básico**
1. O usuário entra na tela de edição de perfil;
2. O sistema solicita as informações do usuário;
3. O usuário informa suas informações;
4. O sistema conclui a edição.

**5.2. Fluxo Alternativo - Cancelar**
1. O usuário entra na tela de edição de perfil;
2. O sistema solicita as informações do usuário;
3. O usuário aperta em "Cancelar";
4. O sistema cancela a operação e direciona o usuário para a tela de perfil.

**5.3. Fluxo de exceção 1 - Nome de usuário inválido**
1. O usuário entra na tela de edição de perfil;
1. O sistema solicita as informações do usuário;
3. O usuário digita um nome de usuário que já está em uso;
4. O sistema informa que esse nome de usuário já está em uso e solicita outro.

**5.4. Fluxo de exceção 2 - Email inválido**
   1. O usuário entra na tela de edição de perfil;
   2. O sistema solicita as informações do usuário;
   3. O usuário digita um email que já está em uso;
   4. O sistema informa que esse email já está em uso e solicita outro.

**5.5. Fluxo de exceção 3 - Biografia muito grande**
1. O usuário entra na tela de edição de perfil;
2. O sistema solicita as informações do usuário;
3. O usuário digita uma biografia com mais de 140 caracteres;
4. O sistema informa que a biografia deve ter no máximo 140 caracteres.

**6 Protótipo(s) de interface do caso de uso**

**Figura 1: protótipo**

![prototipoEditarPerfil](https://user-images.githubusercontent.com/82484797/143936119-69ae57e6-d8f3-4af6-817b-a56aba0ed91c.PNG)
