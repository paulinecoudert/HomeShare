CREATE TABLE [dbo].[Message] (
    [idMessage]   INT            IDENTITY (1, 1) NOT NULL,
    [Nom]         NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (323) NOT NULL,
    [Telephone]   NVARCHAR (12)  NOT NULL,
    [Information] NVARCHAR (MAX) NOT NULL,
    [DateEnvoie]  DATETIME       NOT NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([idMessage] ASC)
);

