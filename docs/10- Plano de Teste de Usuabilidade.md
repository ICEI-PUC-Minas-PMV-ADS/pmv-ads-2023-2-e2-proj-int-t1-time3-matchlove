# Plano de Teste de Usabilidade do Love Match

## Introdução

O objetivo deste teste é avaliar a usabilidade da aplicação web de navegador chamada Love Match, que tem como função conectar pessoas que têm interesses em comum. A aplicação permite que os usuários curtam o perfil de outros usuários, e se ambos curtirem um ao outro, haverá um match que possibilitará aos usuários envolvidos trocarem mensagens.

Será aplicado um teste em Escala Likert de 5 pontos, onde 1 representa "Discordo Totalmente" e 5 representa "Concordo Totalmente"

- As questões de pesquisa que se pretende responder com este teste são:

- A navegação na aplicação é intuitiva e fácil de entender?

- A interface da aplicação é visualmente agradável e organizada?

- A aplicação responde de forma rápida às minhas ações e comandos?

- Eu encontro facilmente as funcionalidades que preciso na aplicação?

- A aplicação fornece feedback claro e informativo sobre minhas ações?


## Casos de Teste

| **Caso de Teste** 	| CT-11 - Publicação Online
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-001: A aplicação deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku).
| **Objetivo do Teste** 	| Verificar se a aplicação está acessível publicamente na Internet através dos ambientes especificados.
| **Passos** 	           |  1. Acessar a plataforma a partir de um navegador web. 
                           |  2. Verificar se a plataforma está disponível nos ambientes mencionados (Repl.it, GitHub Pages, Heroku).
| **Critério de Êxito**  | A aplicação está acessível publicamente na Internet através dos ambientes especificados.

| **Caso de Teste** 	| CT-12 - Responsividade
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-002: A aplicação deverá ser responsiva permitindo a visualização em diferentes telas de forma adequada.
| **Objetivo do Teste** 	| Verificar se a aplicação é responsiva e se pode ser visualizada de forma adequada em diferentes telas.
| **Passos** 	           | 1. Acessar a plataforma a partir de um celular.
                        | 2. Acessar a plataforma a partir de um tablet.
                        | 3. Acessar a plataforma a partir de um computador.
| **Critério de Êxito**  | A aplicação é responsiva em todas as telas testadas, incluindo celular, tablet e computador.

| **Caso de Teste** 	| CT-13 - Contraste de Tela
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-003: A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade.
| **Objetivo do Teste** 	| Avaliar se o contraste entre os elementos da tela é adequado para usuários com deficiências visuais.
| **Passos** 	           | 1. Examinar o contraste entre os elementos da tela.
                        | 2. Verificar se o contraste é suficiente para facilitar a leitura e a compreensão do conteúdo.
| **Critério de Êxito**  | O contraste entre os elementos da tela atende aos padrões de acessibilidade e é adequado para usuários com deficiências visuais.

| **Caso de Teste** 	| CT-14 - Compatibilidade de Navegadores
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-004: A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).
| **Objetivo do Teste** 	| Verificar se a aplicação funciona corretamente nos principais navegadores do mercado.
| **Passos** 	           | 1. Testar a plataforma no Google Chrome.
                        | 2. Testar a plataforma no Mozilla Firefox.
                        | 3. Testar a plataforma no Microsoft Edge.
| **Critério de Êxito**  | A plataforma funciona corretamente e de forma consistente nos principais navegadores, sem diferenças significativas de usabilidade.

| **Caso de Teste** 	| CT-15 - Validação de Cadastro
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-005: A aplicação não permite o recebimento de cadastros de usuários com dados necessários em branco.
| **Objetivo do Teste** 	| Verificar se a aplicação impede o cadastro de usuários com campos obrigatórios em branco.
| **Passos** 	           | 1. Tentar cadastrar um usuário com campos obrigatórios em branco.
                        | 2. Verificar se a aplicação exibe uma mensagem de erro apropriada.
| **Critério de Êxito**  | A aplicação impede o cadastro de usuários com campos obrigatórios em branco e exibe uma mensagem de erro adequada.

| **Caso de Teste** 	| CT-16 - Mensagem de Erro de Cadastro
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-006: A aplicação deverá informar o erro de cadastro e login para o usuário caso os dados inseridos não estejam no banco de dados.
| **Objetivo do Teste** 	| Verificar se a aplicação exibe mensagens de erro adequadas quando ocorre um erro de cadastro ou login.
| **Passos** 	           | 1. Tentar cadastrar um usuário com dados incorretos.
                        | 2. Tentar fazer login com dados incorretos.
                        | 3. Verificar se a aplicação exibe mensagens de erro apropriadas.
| **Critério de Êxito**  | A aplicação exibe mensagens de erro adequadas quando ocorre um erro de cadastro ou login.

| **Caso de Teste** 	| CT-17 - Backup em Nuvem
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-007: A aplicação deverá realizar backup dos dados principais de cadastros dos clientes para um banco de dados em nuvem.
| **Objetivo do Teste** 	| Verificar se a aplicação realiza com sucesso o backup dos dados principais de cadastros dos clientes em um banco de dados em nuvem.
| **Passos** 	           | 1. Realizar cadastro de clientes.
                        | 2. Verificar se os dados são armazenados em um banco de dados em nuvem.
| **Critério de Êxito**  | A aplicação realiza com sucesso o backup dos dados principais de cadastros dos clientes em um banco de dados em nuvem.

| **Caso de Teste** 	| CT-18 - Tecnologias Utilizadas
|--------------------|-----------------------------------------------------------------------------------------------------|
| **Requisito Associado**| RNF-008: A aplicação será desenvolvida através das linguagens C#, .NET e do banco de dados SQL.
| **Objetivo do Teste** 	| Verificar se a aplicação foi desenvolvida usando as tecnologias especificadas.
| **Passos** 	           | 1. Verificar as tecnologias utilizadas no desenvolvimento da aplicação.
| **Critério de Êxito**  | A aplicação foi desenvolvida utilizando as linguagens C#, .NET e o banco de dados SQL, conforme especificado.


## Participantes

Os critérios de seleção e recrutamento dos participantes são:

- Ser maior de 18 anos
- Ter acesso à internet e a um navegador web compatível com a aplicação
- Ter interesse em conhecer pessoas novas que têm interesses em comum
- Não ter usado a aplicação Love Match antes.
- Ter utilizado aplicações semelhantes anteriormente como Tinder, Umatch, badoo.
- Possuir computador com câmera e acesso a internet (para o caso do teste ser realizado remotamente via Microsoft Teams)

O número de participantes será de 13 pessoas, sendo 5 homens e 5 mulheres selecionados com base nos critérios acima, com diferentes níveis de escolaridade e profissões e 3 pessoas da equipe Love Match, sendo elas um moderadora que irá comandar o teste e dois observadores.