Select arvore.id as Id,Especies.nomecientifico as NomeCientifico,altura,perimetro,diametro,validFrom,localizacao,COALESCE(NULLIF(Construcao.tipoconstrucao,''), 'Sem caldeira') as Caldeira from arvore
INNER JOIN Especies ON Especies.Id = arvore.NomeCientifico
LEFT JOIN Construcao ON Construcao.Id = arvore.idConstrucao
Where arvore.ativa = 0