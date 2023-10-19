# DIO - Trilha .NET: Explorando a Linguagem C#

## Desafio de Projeto

Para este desafio, precisei utilizar os conhecimentos adquiridos no módulo "Explorando a Linguagem C#" da trilha .NET da DIO.

## Contexto

Fui contratado para construir um sistema de hospedagem que será usado para realizar reservas em um hotel. Tive que usar as classes Pessoa (representando o hóspede) e Suíte, que foram fornecidas prontas pelo desafio, e a classe Reserva, na qual precisei implementar os métodos. Estabeleci um relacionamento entre essas classes.

Meu programa precisou calcular corretamente os valores dos métodos da classe Reserva, fornecendo a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% se a reserva fosse para um período maior que 10 dias.

## Regras e Validações

1. Não era possível realizar uma reserva em uma suíte com capacidade menor do que a quantidade de hóspedes. Por exemplo, se uma suíte tinha capacidade para hospedar 2 pessoas e fossem passados 3 hóspedes, retornaria uma exceção.

2. O método "ObterQuantidadeHospedes" da classe Reserva teve que retornar a quantidade total de hóspedes, enquanto o método "CalcularValorDiária" teve que retornar o valor da diária (Dias reservados x valor da diária).

3. Se eu fizesse uma reserva igual ou maior que 10 dias, concederia um desconto de 10% no valor da diária.

## Diagrama de Classe

![diagrama_classe_hotel](https://github.com/Ayrton54/DIO---Trilha-.NET---Explorando-a-linguagem-C-/assets/106751266/ff1bcf0d-f44b-40fa-88bc-99690f03d488)


### Desafio Hotel
