CREATE TABLE [dbo].[vol] (
    [numvol]    VARCHAR (6)  NOT NULL,
    [numpilote] INT          NOT NULL,
    [numavion]  INT          NOT NULL,
    [villedep]  VARCHAR (20) NULL,
    [villearr]  VARCHAR (20) NULL,
    [heuredep]  VARCHAR (5)  NULL,
    [heurearr]  VARCHAR (5)  NULL,
    CONSTRAINT [pk_vol] PRIMARY KEY CLUSTERED ([numvol] ASC),
    CONSTRAINT [fk1_vol] FOREIGN KEY ([numpilote]) REFERENCES [dbo].[pilote] ([numpilote]),
    CONSTRAINT [fk2_vol] FOREIGN KEY ([numavion]) REFERENCES [dbo].[avion] ([numavion])
);


GO
CREATE NONCLUSTERED INDEX [VOL_FK1]
    ON [dbo].[vol]([numavion] ASC);


GO
CREATE NONCLUSTERED INDEX [VOL_FK2]
    ON [dbo].[vol]([numpilote] ASC);

