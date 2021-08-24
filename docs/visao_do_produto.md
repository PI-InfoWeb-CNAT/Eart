# Documento de visão

## Rede Social (Trails)

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 05/06/2021 |  **`1.01`** | Versão Inicial  | Alessandro Souza|


### 1. Objetivo do Projeto 

O projeto __Trails__ tem como objetivo ser uma rede social específica para aqueles que realizam seus passeios/trilhas de aventura e lazer.
 

### 2. Descrição do problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | está relacionado a falta de uma rede social específica para trilheiros  |
| **_afetando_**      | pessoas que gostariam de compartilhar fotos e percurso de suas aventuras |
| **_cujo impacto é_**| a falta de divulgação dos eventos entre grupos apropriados.|
| **_Uma boa solução seria_** | a criação de uma rede social que permita o comparilhamento de trilhas realizadas bem como a comunicação entre os grupos de trilheiros.|


### 3. Descrição dos usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Trilheiro  | Membros da rede social e que fazem as trilhas | Postam fotos das trilhas, realizam comentários, etc.|
| Visitante  | Pessoal não cadastrado como membro da rede. | Realizam apenas consultas de postagens, mas não podem fazer comentários nem favoritar uma postagem. |
| Moderador | Administrador do sistema | Além de poderem realiza as atividades inerentes aos trilheiros, podem fazer o desligamento de membros ou cancelamento de postagens indevidas.|

### 4. Descrição do ambiente dos usuários

Por se tratar de uma rede social, as tarefas executadas sobre o sistema são feitas pelos próprios membros ou visitantes da rede. As postagens podem ser feitas em qualquer horário e para isso o sistema deve ter a capacidade de estar habilitado a receber requições 24 horas por dia, durante os 7 dias da semana.

Os locais para interação com o sistema são diversos e estes podem ter uma variação da qualdiade de sinal de internet, fato que pode limitar o acesso ao sistema. 

### 5. Principais necessidades dos usuários
Os trailheiros sentem falta de um ambinete apropriado para postagens de suas aventuras/passeios. Atualmente se tem usado alguns aplicativos de rede social como Facebook, Instagram, entre outros. Como este sistemas são de cunho generalista, seus participantes precisam criar grupos específicos que os identifiquem. Isso causa uma proliferação de grupos que termina prejudicando a comunicação entre a comunidade de trilheiros.

Neste contexto, os trileiros gostariam que fosse construído um sistema exclusivo para os registros e divuldação de seus passeios, como: caminhadas, cavalgadas,trilhas de bicicleta e corridas.

Para isso, o sistema precisaria permitir a realziação de postagens dos passeios com: fotos, textos e percurso. O sistema deve, também, permitir a realização de comentários por parte dos membros da rede sobre determinada postagem e enviar uma mensagem para um membro específico. Além, claro, gerenciar o perfil de cada membro da rede de trilheiros.

Para os trilheiros, também, é importante ter o controle de milagem percurrida por evento.


### 6.	Alternativas concorrentes
Como alternativas concorrentes existem os sistema de rede social existentes atualmente: facebook, instagram, pinterest, Twitter, etc.

### 7.	Visão geral do produto
A nova rede social, específica para trilheiros, deve ser construída para uso em navegadores (_browsers_) existentes no mercado. Sua interface com usuário deve possuir um boa usabilidade e para isto deve se aproximar da forma de interação já difundidas nas redes sociais existentes.

É importante que o sistema possua um interface de comunicação com algum sistema de GPS para receber os dados do percurso das trilhas realizadas.

O sistema deve possuir uma logo marca que identifique-o e que possa ser utilizado pelos seus membros para divulgação em eventos.  

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Gerenciar perfil (conta)| Este requisito tem o propósito de habilitar o membro da rede a consultar e atualizar seus dados de perfil. |
| RF03 | Criar perfil | Permite que pessoas visitantes da rede possam realizar seu cadastro e começar a participar fazendo postagens de suas trilhas. |
| RF04 | Gerenciar postagens |  Membros da rede podem criar, consultar, editar e excluir suas postagens. Como forma de moderar postagens abusivas o administrador do sistema poderá excluir uma postagem. |
| RF05 | Comentar postagens | Pertmite que membros da rede possam fazer comentários em postagens de outro membros. |
| RF06 | Apreciar (like) postagens | Além de poderem fazer comentários sobre uma postagem os membros da rede podem apreciar uma postagem apenas dando um like. |
| RF07 | Consultar percursos | Membros e visitantes da rede podem visualizar em um mapa o percuso da trilha, quando cadastrado durante a postagem.  |
| RF08 | Consultar kilometrage percorrida | Os membros da rede podem consultar o somatório de kilometragem por categoria (caminhada, corrida, etc) de trilha de uma membro. |
| RF09 | Enviar mensagens | O sistem deve permitir a comunicação entre os membros da rede, onde as mensagens devem ser enviadas e consultas no próprio sistema. |
| RF10 | Cancelar membro | Por questões de ordem éticas  um membro da rede pode ter seu perfil cancelado pelo administrador da rede.|


### 9. Requisitos não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo| O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Criptografia de dados| Dados como senha e email do integrantes da rede devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório|
| RNF03 | Facilidade de uso| O sistema deve ter uma interface amigável que possibilite a seus usuários uma interação fácil sem que para isso precise fazer treinamentos e/ou ler manuais. | Usabilidade| Obrigatório |
| RNF04 | Troca de dados |O sistema de usar uma biblioteca [GPSBabel] (https://en.wikipedia.org/wiki/GPSBabel) para manipular arquivos de GPS | Interoperabilidade | Desejável |

