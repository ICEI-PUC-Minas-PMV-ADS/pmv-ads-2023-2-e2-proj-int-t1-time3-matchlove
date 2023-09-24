# Arquitetura da Solução


## Diagrama de Classes

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time3-matchlove/assets/128434710/80afbed1-cbbb-4266-b962-bab290ba4945)


## Modelo Entidade de Relacionamento


![Modelo Entidade de Relacionamento drawio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time3-matchlove/assets/128434710/e2dad788-2a56-4577-ab45-dae64cf60c52)


## Projeto da Base de Dados 

## Estrutura do Banco de Dados - Projeto de Software

### Tabela: Pessoa
| Campo       | Tipo         | Restrições                 |
|-------------|--------------|----------------------------|
| id          | INT          | PRIMARY KEY                |
| nome        | VARCHAR(255) | NOT NULL                   |
| genero      | VARCHAR(10)  |                            |
| dt_nasc     | DATE         |                            |
| orient_sex  | VARCHAR(255) |                            |

### Tabela: Curtidas
| Campo        | Tipo         | Restrições                         |
|--------------|--------------|------------------------------------|
| id           | INT          | PRIMARY KEY                        |
| id_remet     | INT          | NOT NULL, FOREIGN KEY (Pessoa)    |
| id_dest      | INT          | NOT NULL, FOREIGN KEY (Pessoa)    |
| deu_match    | BOOLEAN      | DEFAULT FALSE                      |

### Tabela: Match
| Campo       | Tipo         | Restrições                     |
|-------------|--------------|--------------------------------|
| pessoa_1    | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| pessoa_2    | INT          | NOT NULL, FOREIGN KEY (Pessoa) |

### Tabela: Mensagem
| Campo       | Tipo         | Restrições                     |
|-------------|--------------|--------------------------------|
| id_msg      | INT          | PRIMARY KEY                     |
| id_remet    | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| id_dest     | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| mensagem    | TEXT         |                                |

### Tabela: Denuncia
| Campo       | Tipo         | Restrições                     |
|-------------|--------------|--------------------------------|
| id_denuncia | INT          | PRIMARY KEY                     |
| id_remet    | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| id_dest     | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| motivo      | VARCHAR(255) |                                |

### Tabela: Participantes
| Campo       | Tipo         | Restrições                     |
|-------------|--------------|--------------------------------|
| id          | INT          | PRIMARY KEY                     |
| id_pessoa   | INT          | NOT NULL, FOREIGN KEY (Pessoa) |
| id_evento   | INT          | NOT NULL, FOREIGN KEY (Evento)  |

### Tabela: Evento
| Campo       | Tipo         | Restrições                     |
|-------------|--------------|--------------------------------|
| id          | INT          | PRIMARY KEY                     |
| nome_evento | VARCHAR(255) |                                |
| data_evento | DATE         |                                |
