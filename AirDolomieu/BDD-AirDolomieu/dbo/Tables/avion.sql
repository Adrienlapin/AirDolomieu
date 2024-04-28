CREATE TABLE [dbo].[avion] (
    [numavion]     INT          NOT NULL,
    [nomavion]     VARCHAR (20) NULL,
    [capacite]     INT          NULL,
    [localisation] VARCHAR (20) DEFAULT ('Paris') NOT NULL,
    CONSTRAINT [pk_avion] PRIMARY KEY CLUSTERED ([numavion] ASC),
    CONSTRAINT [cid_capacite] CHECK ([capacite]=(460) OR [capacite]=(450) OR [capacite]=(380) OR [capacite]=(360) OR [capacite]=(320) OR [capacite]=(300) OR [capacite]=(250) OR [capacite]=(200) OR [capacite]=(180) OR [capacite]=(140))
);

