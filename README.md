CotaçãoDolar
=============

Aplicativo Windows Forms simples para converter o valor de uma mercadoria em dólares (US$) para reais (R$) usando a cotação do dia.

Pré-requisitos
--------------
- .NET 10 SDK
- Visual Studio 2022/2024/2026 ou qualquer IDE que suporte .NET 10

Como executar
--------------
1. Abra a solução CotaçãoDolar.slnx no Visual Studio e execute (F5) ou:
2. Pelo terminal (PowerShell):

   dotnet build
   dotnet run --project "CotaçãoDolar/CotaçãoDolar.csproj"

Como usar
---------
1. Informe o valor em US$ no campo "Valor em US$".
2. Informe a cotação do dólar em reais no campo "Cotação (R$)".
3. Clique em "Converter". O resultado aparece no formato pt-BR (ex.: 1.234,56).

Observações
-----------
- O aplicativo aceita vírgula ou ponto como separador decimal na entrada.
- Projeto simples de demonstração — ideal para aprendizado.

Contribuições
-------------
Pull requests são bem-vindos. Para mudanças maiores, abra uma issue primeiro para discutir o que pretende alterar.

Licença
-------
MIT
