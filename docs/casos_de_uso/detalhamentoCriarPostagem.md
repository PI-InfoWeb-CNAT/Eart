**Eart - Rede Social**

**Especificação do caso de uso
Criar Postagem**

**Histórico da Revisão**



| **Data**   | **Versão** | **Descrição**                              | **Autor**                                                    |
| ---------- | ---------- | ------------------------------------------ | ------------------------------------------------------------ |
| 04/01/2022 | 1.0        | Detalhamento do caso de uso Criar Postagem | Aristóteles, Alexsander, Mariana, Viviane, Marcos Vinícius Maia |


**1 Resumo**

Esse caso de uso descreve as etapas percorridas pelo usuário para criar uma postagem na rede social Eart.

**2 Atores**

Usuário

**3 Pré-condições**

1. Ter um cadastro

**4 Pós-condições**

1. Ao concluir a postagem, o usuário deve ser redirecionado para a página em que se encontrava inicialmente.

**5 Fluxos de evento**

**5.1. Fluxo básico**
1. O usuário aperta em "Criar Publicação";
2. O sistema apresenta uma caixa de texto em que o usuário pode escrever o texto da publicação e anexar imagens;
3. O usuário monta a publicação e aperta em "Publicar";
4. O sistema posta a publicação.

**5.2. Fluxo Alternativo - Cancelar**
1. O usuário aperta em "Criar Publicação";
2. O sistema apresenta uma caixa de texto em que o usuário pode escrever o texto da publicação e anexar imagens;
3. O usuário aperta em "Cancelar";
4. O sistema cancela a operação e redireciona o usuário para a página em que se encontrava inicialmente,

**5.3. Fluxo de exceção 1 - Publicação vazia**
1. O usuário aperta em "Criar Publicação";
2. O sistema apresenta uma caixa de texto em que o usuário pode escrever o texto da publicação e anexar imagens;
3. O usuário não adiciona nenhum texto ou imagem e aperta em "Publicar";
4. O sistema informa que a publicação está vazia.
