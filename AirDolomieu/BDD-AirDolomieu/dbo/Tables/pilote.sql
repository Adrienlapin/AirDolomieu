CREATE TABLE [dbo].[pilote] (
    [numpilote] INT          NOT NULL,
    [nompilote] VARCHAR (20) NULL,
    [adresse]   VARCHAR (20) NULL,
    CONSTRAINT [pk_pilote] PRIMARY KEY CLUSTERED ([numpilote] ASC)
);

