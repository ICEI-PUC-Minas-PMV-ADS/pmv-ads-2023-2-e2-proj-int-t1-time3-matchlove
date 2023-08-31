#  Especificação do projeto

A identificação do problema e dos aspectos mais relevantes a serem abordados neste projeto foi realizada por meio de pesquisas e observação dos usuários. Para detalhar esses aspectos, foram utilizadas personas e histórias de usuários. 

## Personas

### Persona: Fernanda Silva

- **Idade:** 55
- **Ocupação:** Servidora pública.
- **Aplicativos:** Facebook, Instagram, WhatsApp
- **Motivações:** Gostaria de encontrar uma companheira.
- **Frustrações:** Se sente sozinha; Não gosta de sair para locais com grande aglomeração de pessoas.
- **Hobbies, História:** Divorciada; Mora sozinha.

### Persona: Samuel Santos

- **Idade:** 22
- **Ocupação:** Estudante
- **Aplicativos:** Facebook, Instagram, Discord
- **Motivações:** Conhecer pessoas, mas sem necessidade de encontrar um companheiro.
- **Frustrações:** Dificuldade em tomar a iniciativa de conversar pessoalmente com desconhecidos.
- **Hobbies, História:** Jogos online, Natação, Assistir séries.


### Persona: Lucas Mendes

- **Idade:** 18
- **Ocupação:** Estudante universitário
- **Aplicativos:** Instagram, Snapchat, TikTok
- **Motivações:** Procurando por encontros casuais e novas amizades.
- **Frustrações:** Nervoso em situações sociais; quer conhecer pessoas fora do ambiente acadêmico.
- **Hobbies, História:** Tocar violão, Futebol, Jogos online.

### Persona: Sofia Almeida

- **Idade:** 27
- **Ocupação:** Enfermeira
- **Aplicativos:** Instagram, Facebook, WhatsApp
- **Motivações:** Interessada em conhecer pessoas para encontros e construir relacionamentos mais profundos.
- **Frustrações:** Horários irregulares de trabalho dificultam a vida social; deseja alguém que compreenda sua profissão.
- **Hobbies, História:** Corrida, Cuidados com a saúde, Maratonar séries médicas.

### Persona: Rafael Pereira

- **Idade:** 38
- **Ocupação:** Professor
- **Aplicativos:** Twitter, Facebook, WhatsApp
- **Motivações:** Busca por um parceiro de vida; valoriza inteligência e conversas profundas.
- **Frustrações:** Dificuldade em encontrar pessoas com interesses intelectuais; quer alguém que compartilhe sua paixão pela educação.
- **Hobbies, História:** Leitura de clássicos, Ensino, Ativismo social.

### Persona: Pedro Santos

- **Idade:** 75
- **Ocupação:** Aposentado
- **Aplicativos:** Facebook, WhatsApp
- **Motivações:** Deseja encontrar companhia para atividades sociais e viagens.
- **Frustrações:** Falta de oportunidades de socialização na sua idade; busca por alguém que compartilhe seu amor pela vida.
- **Hobbies, História:** Pintura, Dança de salão, Voluntariado em causas sociais.

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| A plataforma deve apresentar na página principal uma seleção dinâmica de icones de perfis por meio dos cadastros realizados (canais) (API). | ALTA | 
|RF-02| A plataforma deve apresentar, para cada usuário, uma imagem correspondente ào usuário,.  (thumbnail).   | MÉDIA |
|RF-03| A plataforma deve permitir ao usuário visualizar informações interativas sobre outro usuário, como filme preferido, hobbies. (Nada de entrevista de emprego).  | MÉDIA |
|RF-04| A plataforma deve oferecer um menu adicional que permita ao usuário visualizar publicações dos usuários sobre assuntos diversos, criando interesses sem precisar dar MATCH.      | MÉDIA |
|RF-05| A plataforma deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar interesses mutuos,| ALTA |
|RF-08| A plataforma deve permitir que os usuários salvem os perfis pesquisados, publicações de usuários, armazenando essas informações no armazenamento local do navegador.  | MÉDIA |
|RF-09| A plataforma deve permitir verificar os usuários, como autenticação segura. | ALTA |
|RF-10| A plataforma deve permitir que os usuários possam comentar sobre as publicações. | MÉDIA |




### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01 | A plataforma deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-02 | A plataforma deverá ser responsivo permitindo a visualização em um celular de forma adequada |  ALTA | 
|RNF-03 | A plataforma deve ter bom nível de contraste entre os elementos da tela em conformidade | MÉDIA|
|RNF-04 | A plataforma deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) | ALTA|



### Restrições do Projeto

Abaixo são apresentadas as restrições que limitam a execução do plano e que devem ser obedecidas para garantir o sucesso do projeto.

| **ID**  | **Descrição**                                                                                   |
|---------|-------------------------------------------------------------------------------------------------|
| RE-01   | O projeto precisa ser finalizado dentro do prazo estabelecido, sem nenhum tipo de atraso.     |
| RE-02   | A equipe encarregada do desenvolvimento do sistema deve ser o Grupo 3 da disciplina de Projeto: Desenvolvimento da aplicação Back-End. |
| RE-03   | O sistema não tem permissão para ser utilizado por usuários com idade superior a 18 anos.    |
| RE-04   | O sistema deve aderir estritamente às diretrizes da disciplina.                               |


##  Casos de uso 

## Persona: Fernanda Silva (55 anos, Servidora pública)

1. **Encontrar amizades com interesses similares**: Fernanda utiliza o aplicativo de relacionamento para procurar outras mulheres com interesses em comum, visando construir amizades e se sentir menos sozinha.

2. **Participar de grupos virtuais**: Fernanda se junta a grupos de discussão e atividades online no aplicativo, nos quais pode interagir com outras mulheres que também desejam encontrar companheiras, superando a aversão a aglomerações físicas.

## Persona: Samuel Santos (22 anos, Estudante)

1. **Conectar-se com colegas de faculdade**: Samuel usa o aplicativo para encontrar colegas de faculdade e se aproximar deles, compartilhando interesses acadêmicos e sociais.

2. **Participar de comunidades de jogos online**: Samuel ingressa em comunidades de jogos no Discord, onde pode conversar com pessoas que compartilham sua paixão por jogos, superando sua dificuldade em iniciar conversas pessoais.

## Persona: Lucas Mendes (18 anos, Estudante universitário)

1. **Explorar perfis de interesse**: Lucas navega pelos perfis de outros estudantes universitários no aplicativo, procurando pessoas com interesses semelhantes para iniciar conversas e amizades.

2. **Participar de eventos sociais universitários**: Lucas usa o aplicativo para descobrir eventos sociais fora do ambiente acadêmico, como encontros casuais e festas, onde ele pode conhecer novas pessoas e fazer amizades.

## Persona: Sofia Almeida (27 anos, Enfermeira)

1. **Conectar-se com colegas da área da saúde**: Sofia usa o aplicativo para encontrar outros profissionais de saúde e compartilhar experiências relacionadas ao trabalho, aproveitando para construir relacionamentos mais profundos.

2. **Agendar encontros flexíveis**: Devido aos horários irregulares de trabalho, Sofia utiliza o aplicativo para encontrar pessoas que compreendem suas limitações de tempo e estão dispostas a marcar encontros em horários convenientes para ambos.

## Persona: Rafael Pereira (38 anos, Professor)

1. **Participar de grupos de discussão intelectual**: Rafael se junta a grupos no Twitter e Facebook focados em debates e discussões intelectuais, onde ele pode encontrar pessoas que compartilham sua paixão pela educação.

2. **Agendar encontros baseados em livros**: Rafael utiliza o aplicativo para marcar encontros com potenciais parceiros interessados em discutir literatura e clássicos, criando oportunidades para conexões significativas.

## Persona: Pedro Santos (75 anos, Aposentado)

1. **Explorar eventos sociais para a terceira idade**: Pedro utiliza o aplicativo para descobrir eventos e grupos de interesse para pessoas mais velhas, como dança de salão e atividades de voluntariado.

2. **Encontrar parceiros de viagem**: Pedro usa o aplicativo para conhecer pessoas que compartilham seu interesse por viagens e aventuras, permitindo-lhe encontrar companhia para explorar novos lugares.


