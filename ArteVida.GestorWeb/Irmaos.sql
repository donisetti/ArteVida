SET DATEFORMAT dmy;
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 1, 'Luan Aparecido dos Santos', '17 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 1, 'Lucas Manuel dos Santos', '19 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 1, 'Flavio Augusto', '7 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 7, 'Isadora dos Santos', '8 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 9, 'Thamily Gabriely dos Santos Bezerra', '6 meses',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 9, 'Andreina Vitoria dos Santos Bezerra', '12 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 12, 'Jessica Cristina de Souza Neves', '13 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 12, 'Jeferson Junior Souza Neves', '9 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 15, 'Andre Oliveira da Silva', '13 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 15, 'Mateus Oliveira Peliceu', '15 anos',1);
INSERT INTO [dbo].[Irmaos] (Numero, Nome, Idade,PessoaId) VALUES ( 15, 'Adson Junior de Oliveira da Cruz', '15 anos',1);
UPDATE Irmaos SET  PessoaId = Pessoas.PessoaId FROM  Irmaos LEFT OUTER JOIN Pessoas ON Irmaos.Numero = Pessoas.NumeroFicha;