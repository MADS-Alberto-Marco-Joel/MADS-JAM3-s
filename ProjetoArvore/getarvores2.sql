Select arvore.id as Id,Especies.nomecientifico as NomeCientifico,altura,diametro,validFrom,localizacao,classificacao
from arvore 
INNER JOIN Especies ON Especies.Id = arvore.NomeCientifico
Where arvore.ativa = 0