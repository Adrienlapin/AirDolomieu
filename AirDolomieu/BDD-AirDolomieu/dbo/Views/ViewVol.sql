CREATE VIEW ViewVol AS
SELECT v.numvol,TRIM(p.nompilote) as nompilote,(TRIM(a.nomavion)+'-'+CAST(a.numavion AS VARCHAR(10))) as nomavion,villedep,villearr,heuredep,heurearr
  FROM vol v
  inner join avion a on a.numavion = v.numavion
  inner join pilote p on p.numpilote = v.numpilote;