USE [QuironDatabase]
GO

/****** Object:  View [dbo].[Selecoes]    Script Date: 20/09/2015 09:55:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Selecoes]
AS
SELECT        LinhaCodigo, LinhaDescricao
FROM            dbo.Linha
WHERE        (LinhaCodigo IN (
0001,
0007,
0015,
0018,
0020,
0021,
0022,
0026,
0319,
0173,
0259,
0261,
0262,
0263,
0264,
0265,
0266,
0267,
0269,
0271,
0273,
0274,
0277,
0280,
0281,
0282,
0283,
0284,
0285,
0286,
0287,
0288,
0289))

GO


