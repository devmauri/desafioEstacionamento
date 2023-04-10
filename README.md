# DIO - Trilha .NET
www.dio.me


## Atividade
Informar o valor que um veiculo devera pagar ao estacionar. App via console.

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de veiculos estacionados.

## Ações
**Adicionar veiculo** - informar a placa e o sistema deve pegar hora atual.
**Listar Veiculoss** - Imprimir todos os veiculos estacionados.
**Remover Veiculo** - Dar baixa no veiculo estacionado calculando seu valor com base na hora corrente.
**Pegar veiculo** - Informar a placa e retornar os dados de um unico veiculo.

## Metodologia

A partir de uma entrada única é printado em tela o menu de opções. 
Uma classe é responsável pela regra de negócios, outra por acessar as informações e um terceira para reter os dados.
Ainda existe a classe Veiculo representando os veiculos estacionados com suas particularidades e um interface iCRUD<T> para padronizar as futuras entradas. 


