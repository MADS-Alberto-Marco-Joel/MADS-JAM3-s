Select arvore.id as Id,Especies.nomecientifico as NomeCientifico,altura,diametro,validFrom,Construcao.tipoconstrucao,localizacao,classificacao
from arvore 
INNER JOIN Especies ON Especies.Id=arvore.NomeCientifico
INNER JOIN Construcao ON arvore.idConstrucao=Construcao.Id
Where arvore.ativa=0