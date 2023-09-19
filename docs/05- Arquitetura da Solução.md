# Arquitetura da Solução


## Diagrama de Classes

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time3-matchlove/assets/128434710/a7188e19-24ba-4966-8c68-52539d11a9a0)


## Modelo Entidade de Relacionamento


![Modelo Entidade de Relacionamento drawio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t1-time3-matchlove/assets/128434710/e2dad788-2a56-4577-ab45-dae64cf60c52)


## Projeto da Base de Dados 

-- Tabela para armazenar informações sobre as pessoas
CREATE TABLE Pessoa (
    id INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    genero VARCHAR(10),
    dt_nasc DATE,
    orient_sex VARCHAR(255)
);

-- Tabela para registrar as curtidas e correspondências
CREATE TABLE Curtidas (
    id INT PRIMARY KEY,
    id_remet INT NOT NULL, -- ID da pessoa que enviou a curtida
    id_dest INT NOT NULL, -- ID da pessoa que recebeu a curtida
    deu_match BOOLEAN DEFAULT FALSE, -- Indica se houve um "match"
    FOREIGN KEY (id_remet) REFERENCES Pessoa(id),
    FOREIGN KEY (id_dest) REFERENCES Pessoa(id)
);

-- Tabela para registrar correspondências
CREATE TABLE Match (
    pessoa_1 INT NOT NULL,
    pessoa_2 INT NOT NULL,
    PRIMARY KEY (pessoa_1, pessoa_2), -- A combinação de pessoas forma uma chave primária composta
    FOREIGN KEY (pessoa_1) REFERENCES Pessoa(id),
    FOREIGN KEY (pessoa_2) REFERENCES Pessoa(id)
);

-- Tabela para armazenar mensagens
CREATE TABLE Mensagem (
    id_msg INT PRIMARY KEY,
    id_remet INT NOT NULL, -- ID da pessoa que enviou a mensagem
    id_dest INT NOT NULL, -- ID da pessoa que recebeu a mensagem
    mensagem TEXT,
    FOREIGN KEY (id_remet) REFERENCES Pessoa(id),
    FOREIGN KEY (id_dest) REFERENCES Pessoa(id)
);

-- Tabela para registrar denúncias
CREATE TABLE Denuncia (
    id_denuncia INT PRIMARY KEY,
    id_remet INT NOT NULL, -- ID da pessoa que fez a denúncia
    id_dest INT NOT NULL, -- ID da pessoa denunciada
    motivo VARCHAR(255),
    FOREIGN KEY (id_remet) REFERENCES Pessoa(id),
    FOREIGN KEY (id_dest) REFERENCES Pessoa(id)
);

-- Tabela para associar pessoas a eventos
CREATE TABLE Participantes (
    id INT PRIMARY KEY,
    id_pessoa INT NOT NULL, -- ID da pessoa que está participando do evento
    id_evento INT NOT NULL, -- ID do evento
    FOREIGN KEY (id_pessoa) REFERENCES Pessoa(id),
    FOREIGN KEY (id_evento) REFERENCES Evento(id)
);

-- Tabela para eventos
CREATE TABLE Evento (
    id INT PRIMARY KEY,
    nome_evento VARCHAR(255),
    data_evento DATE
);
