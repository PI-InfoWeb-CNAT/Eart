# Documento de visão

## Rede Social (Beyond School)

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/08/2021 |  **`1.0`** | Versão Inicial  | Alexsander Anulino, Aristóteles Daniel, Marcos Vinícius, Mariana Raquel, Viviane Pereira |


### 1. Objetivo do Projeto 

O projeto __Beyond School__ tem como objetivo ser uma rede social específica para aqueles interessados em atividades extracurriculares.


### 2. Descrição do problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | está relacionado a falta de uma rede social específica para atividades extracurriculares |
| **_afetando_**      | pessoas que gostariam de compartilhar e descobrir experiências extracurriculares |
| **_cujo impacto é_**| um ambiente para compartilhamento de experiências extracurriculares.|
| **_Uma boa solução seria_** | a criação de uma rede social que permita o compartilhamento de atividades extracurriculares bem como a comunicação entre os grupos interessados. |


### 3. Descrição dos usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Membro  | Membros da rede social que compartilham atividades extracurriculares | Postam experiências extracurriculares , realizam comentários, podem dar like, etc.|
| Visitante  | Pessoal não cadastrado como membro da rede. | Realizam apenas consultas de postagens, mas não podem fazer comentários nem favoritar uma postagem. |
| Moderador | Administrador do sistema | Além de poderem realizar as atividades inerentes aos membros, podem fazer o desligamento destes ou cancelamento de postagens indevidas. |


### 4. Descrição do ambiente dos usuários

Por se tratar de uma rede social, as tarefas executadas sobre o sistema são feitas pelos próprios membros ou visitantes da rede. As postagens podem ser feitas em qualquer horário e para isso o sistema deve ter a capacidade de estar habilitado a receber requisições 24 horas por dia, durante os 7 dias da semana.

Os locais para interação com o sistema são diversos e estes podem ter uma variação da qualidade de sinal de internet, fato que pode limitar o acesso ao sistema. 

### 5. Principais necessidades dos usuários
As pessoas que praticam ou buscam atividades extracurriculares sentem falta de um ambiente apropriado para conversar sobre e postar suas atividades . Atualmente se tem usado alguns aplicativos de rede social como Facebook, Instagram, entre outros. Como estes sistemas são de cunho generalista, seus participantes precisam criar grupos específicos que os identifiquem. Isso causa uma proliferação de grupos que termina prejudicando a comunicação entre a comunidade.

Neste contexto, eles gostariam que fosse construído um sistema exclusivo para os registros e divulgação de suas atividades, como: intercâmbio, cursos, summer programs, etc.

Para isso, o sistema precisaria permitir a realização de postagens das atividades com fotos e textos. O sistema deve, também, permitir a realização de comentários por parte dos membros da rede sobre determinada postagem e enviar uma mensagem para um membro específico. Além, claro, gerenciar o perfil de cada membro da rede.


### 6.	Alternativas concorrentes
Como alternativas concorrentes existem os sistema de rede social existentes atualmente: Facebook, Instagram, Pinterest, Twitter, Linkedin, etc.

### 7.	Visão geral do produto
A nova rede social, específica para interessados em atividades extracurriculares, deve ser construída para uso em navegadores (_browsers_) existentes no mercado. Sua interface com usuário deve possuir um boa usabilidade e para isto deve se aproximar da forma de interação já difundidas nas redes sociais existentes.

O sistema deve possuir uma logo marca que identifique-o e que possa ser utilizado pelos seus membros para divulgação em eventos. 

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Gerenciar perfil (conta)| Este requisito tem o propósito de habilitar o membro da rede a consultar e atualizar seus dados de perfil. |
| RF02 | Criar perfil | Permite que pessoas visitantes da rede possam realizar seu cadastro e começar a participar fazendo postagens de suas atividades. |
| RF03 | Gerenciar postagens | Membros da rede podem criar, consultar, editar e excluir suas postagens. Como forma de moderar postagens abusivas o administrador do sistema poderá excluir uma postagem. |
| RF04 | Comentar postagens | Permite que membros da rede possam fazer comentários em postagens de outro membros. |
| RF05 | Curtir postagens | Além de poderem fazer comentários sobre uma postagem os membros da rede podem apreciar uma postagem apenas dando um like. |
| RF06 | Enviar mensagens | O sistem deve permitir a comunicação entre os membros da rede, onde as mensagens devem ser enviadas e consultadas no próprio sistema. |
| RF07 | Excluir mensagens | Um membro pode excluir as mensagens que envia. |
| RF08 | Cancelar membro | Por questões de ordem éticas um membro da rede pode ter seu perfil cancelado pelo administrador da rede.|
| RF09 | Seguir perfil | Um membro pode seguir outros membros da rede e acompanhar o conteúdo postado por eles. |
| RF10 | Salvar postagem | Permite um membro salvar postagens de outros membros para ver depois. |
| RF11 | Cancelar perfil | Membros podem cancelar suas contas na rede. |
| RF12 | Visualizar postagens em alta | Visitantes e membros podem visualizar postagens em alta. |
| RF13 | Visualizar postagens de membros seguidos | Membros podem visualizar postagens de membros que eles seguem. |
| RF14 | Visitar perfil | Membros podem visitar o perfil de outros membros. |
| RF15 | Bloquear usuário | Os membros devem ter a opção de bloquear outros perfis. |
| RF16 | Denunciar usuário | Os membros devem ter a opção de denunciar outros perfis. |
| RF17 | Denunciar postagem | Permite que os membros denunciem postagens. |
| RF18 | Pesquisar postagens, perfis e hashtags | Membros e visitantes podem pesquisar postagens, perfis e hashtags. |
| RF19 | Compartilhar postagens| Possibilita aos membros compartilhar postagens de outros membros no próprio perfil. |
| RF20 | Ampliar imagens | Membros e visitantes podem ampliar imagens de postagens ao clicarem sobre ela. |
| RF21 | Ver notificações | Membros podem ver notificações sobre suas interações na rede. |
| RF22 | Ativar modo noturno | Membros podem ativar o modo escuro na rede social. |
| RF23 | Curtir comentários | Permite que membros curtam comentários. |
| RF24 | Responder comentários | Membros podem responder comentários. |
| RF25 | Apagar comentários | Membros podem apagar comentários. |

### 9. Requisitos não-funcionais

| Código | Nome                  | Descrição                                                    | Categoria   | Classificação |
| ------ | --------------------- | ------------------------------------------------------------ | ----------- | ------------- |
| RNF01  | Design responsivo     | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade | Obrigatório   |
| RNF02  | Criptografia de dados | Dados como senha e email do integrantes da rede devem ser gravadas de forma criptografada no banco de dados. | Segurança   | Obrigatório   |
| RNF03  | Facilidade de uso     | O sistema deve ter uma interface amigável que possibilite a seus usuários uma interação fácil sem que para isso precise fazer treinamentos e/ou ler manuais. | Usabilidade | Obrigatório   |
