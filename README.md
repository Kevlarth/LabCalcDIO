# LabCalcDIO
&nbsp;&nbsp;&nbsp;&nbsp;Este projeto implementa uma calculadora básica (Calculadora classe) em C# com os seguintes recursos:


## Operações Aritméticas Básicas:

* Adições; 
* Subtrações;
* Multiplicações;
* Divisões;
* Rastreamento Histórico: Mantém um registro dos três cálculos mais recentes (até 3 entradas);
* Testes Unitários: Fornece testes unitários (TestesLabCalcDIO classe) para verificar a correção da lógica da calculadora;

## Começando

### 1 - Pré-requisitos:

* .NET Framework ou .NET Core instalado (https://dotnet.microsoft.com/en-us/download/dotnet-framework)
* Um IDE C# (por exemplo, Visual Studio, Visual Studio Code)

### 2 - Clonar o Repositório:

Bash
```
git clone https://github.com/your-username/LabCalcDIO.git
```

### 3 - Construir o Projeto:
Abra a solução em seu IDE e construa o projeto (consulte as instruções específicas do seu IDE).

## Uso
### 1 - Instanciar a Calculadora:

C#
```
Calculadora calc = new Calculadora();
```

### 2 - Realizar Cálculos:

C#
```
int soma = calc.Somar(5, 3); // Retorna 8
int diferenca = calc.Subtrair(10, 2); // Retorna 8
int produto = calc.Multiplicar(4, 6); // Retorna 24
int quociente = calc.Dividir(27, 3); // Retorna 9
```

### 3 - Acessar o Histórico de Cálculos (Limitado aos Últimos 3):

C#
```
List<string> historico = calc.Historico();
// historico conterá entradas como "Resultado Soma: 8"
```


## Testando
&nbsp;&nbsp;&nbsp;&nbsp;O projeto inclui testes unitários (```TestesLabCalcDIO classe```) para garantir a funcionalidade da calculadora. Você pode executar esses testes usando uma estrutura de teste unitário como NUnit ou xUnit (as instruções de instalação podem variar).

## Contribuindo
Agradecemos as contribuições para este projeto! Sinta-se à vontade para bifurcar o repositório, fazer alterações e enviar solicitações pull.
