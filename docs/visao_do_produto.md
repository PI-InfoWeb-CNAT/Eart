# Documento de visão

## Rede Social (Eart)

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 07/09/2021 |  **`1.0`** | Versão Inicial  | Alexsander Anulino, Aristóteles Daniel, Marcos Vinícius, Mariana Raquel, Viviane Pereira |


### 1. Objetivo do Projeto 

O projeto __Eart__ tem como objetivo ser uma rede social específica para aqueles interessados em compartilhar suas artes e buscar inspiração.


### 2. Descrição do problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | está relacionado à falta de uma rede social específica para artes que possibilite interação ativa entre seus usuários |
| **_afetando_**      | pessoas que gostariam de compartilhar suas artes e descobrir outras |
| **_cujo impacto é_**| um ambiente para compartilhamento de artes |
| **_Uma boa solução seria_** | a criação de uma rede social que permita o compartilhamento de artes bem como a comunicação entre os grupos interessados. |


### 3. Descrição dos usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Membro  | Membros da rede social que compartilham suas artes e veem artes de outras pessoas | Postam artes, realizam comentários, podem dar like, etc.|
| Visitante  | Pessoal não cadastrado como membro da rede. | Realizam apenas consultas de postagens, mas não podem fazer comentários nem favoritar uma postagem. |
| Moderador | Administrador do sistema | Além de poderem realizar as atividades inerentes aos membros, podem fazer o desligamento destes ou cancelamento de postagens indevidas. |


### 4. Descrição do ambiente dos usuários

Por se tratar de uma rede social, as tarefas executadas sobre o sistema são feitas pelos próprios membros ou visitantes da rede. As postagens podem ser feitas em qualquer horário e para isso o sistema deve ter a capacidade de estar habilitado a receber requisições 24 horas por dia, durante os 7 dias da semana.

Os locais para interação com o sistema são diversos e estes podem ter uma variação da qualidade de sinal de internet, fato que pode limitar o acesso ao sistema. 

### 5. Principais necessidades dos usuários
Os artistas sentem falta de um ambiente apropriado para interagir com outros artistas e postar suas atividades. Atualmente se tem usado alguns aplicativos de rede social como Facebook, Instagram, Pinterest, DeviantArt, ArtStation, entre outros. Alguns desses sistemas são de cunho generalista, seus participantes precisam criar grupos específicos que os identifiquem. Isso causa uma proliferação de grupos que termina prejudicando a comunicação entre a comunidade. Além disso, mesmo nos que são específicos para arte, os usuários reclamam sobre aspectos de velocidade, performance, linguagem, usabilidade, etc.

Neste contexto, eles gostariam que fosse construído um sistema exclusivo para os registros e divulgação de suas artes, como: desenhos, pinturas, animações, etc.

Para isso, o sistema precisaria permitir a realização de postagens das atividades com fotos e textos. O sistema deve, também, permitir a realização de comentários por parte dos membros da rede sobre determinada postagem e enviar uma mensagem para um membro específico. Além, claro, gerenciar o perfil de cada membro da rede.

### 6.	Alternativas concorrentes
Como alternativas concorrentes existem os sistema de rede social existentes atualmente: Facebook, Instagram, Pinterest, Twitter, Linkedin, DeviantArt, ArtStation, etc.

### 7.	Visão geral do produto
A nova rede social, específica para interessados arte, deve ser construída para uso em navegadores (_browsers_) existentes no mercado. Sua interface com usuário deve possuir um boa usabilidade e para isto deve se aproximar da forma de interação já difundidas nas redes sociais existentes.

O sistema deve possuir uma logo marca que identifique-o e que possa ser utilizado pelos seus membros para divulgação em eventos. 

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Gerenciar perfil (conta)| Este requisito tem o propósito de habilitar o membro da rede a consultar e atualizar seus dados de perfil. |
| RF02 | Criar perfil | Permite que pessoas visitantes da rede possam realizar seu cadastro e começar a participar fazendo postagens de suas artes. |
| RF03 | Deletar perfil | Um membro pode cancelar seu perfil quando quiser ou, por questões de ordem ética, um administrador da rede pode realizar o cancelamento. |
| RF04 | Bloquear perfil | Os membros devem ter a opção de bloquear outros perfis. |
| RF05 | Visitar perfil | Membros podem visitar o perfil de outros membros. |
| RF06 | Seguir perfil | Um membro pode seguir outros membros da rede e acompanhar o conteúdo postado por eles. |
| RF07 | Gerenciar postagens | Membros da rede podem criar, consultar, editar e excluir suas postagens. Como forma de moderar postagens abusivas, o administrador do sistema poderá excluir uma postagem. |
| RF08 | Denunciar postagem | Permite que os membros denunciem postagens. |
| RF09 | Curtir postagens | Os membros da rede podem apreciar uma postagem apenas dando um like. |
| RF10 | Compartilhar postagens| Possibilita aos membros compartilhar postagens de outros membros no próprio perfil. |
| RF11 | Gerenciar comentários | Membros da rede podem criar, consultar, editar e excluir comentários em suas postagens ou na de outros membros. Como forma de moderar comentários abusivos, o administrador do sistema poderá excluir um comentário. |
| RF12 | Visualizar postagens em alta | Visitantes e membros podem visualizar postagens em alta. |
| RF13 | Visualizar postagens de membros seguidos | Membros podem visualizar postagens de membros que eles seguem. |
| RF14 | Pesquisar postagens, perfis e hashtags | Membros e visitantes podem pesquisar postagens, perfis e hashtags. |
| RF15 | Enviar mensagens | O sistem deve permitir a comunicação entre os membros da rede, onde as mensagens devem ser enviadas e consultadas no próprio sistema. |
| RF16 | Ver notificações | Membros podem ver notificações sobre suas interações na rede. |
| RF17 | Fazer login / logout | Membros podem entrar e sair da conta. |
| RF18 | Notificar perfil | Moderadores podem notificar o perfil dos membros caso eles descumpram as diretrizes do site. |
| RF19 | Deletar postagem | Moderadores podem deletar postagens que descumprem as diretrizes do site. |


### 9. Requisitos não-funcionais

| Código | Nome                  | Descrição                                                    | Categoria   | Classificação |
| ------ | --------------------- | ------------------------------------------------------------ | ----------- | ------------- |
| RNF01  | Design responsivo     | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade | Obrigatório   |
| RNF02  | Criptografia de dados | Dados como senha e email do integrantes da rede devem ser gravadas de forma criptografada no banco de dados. | Segurança   | Obrigatório   |
| RNF03  | Facilidade de uso     | O sistema deve ter uma interface amigável que possibilite a seus usuários uma interação fácil sem que para isso precise fazer treinamentos e/ou ler manuais. | Usabilidade | Obrigatório   |
