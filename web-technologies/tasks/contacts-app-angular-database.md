# contacts-app database

Tietokannan käyttöönotto Back-End-sovelluksessa. 

-  Asenna MS SQL Server [täältä](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
-  Asenna MS SQL Server Management Studio [täältä](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
-  Lue alla olevat ohjeet!
-  Luo oma [DbContext](https://msdn.microsoft.com/en-us/library/jj729737(v=vs.113).aspx)-luokka
-  Konfiguroi sovellus käyttämään tietokantaa (Startup.cs):
   - DbContext:n lisäys ServiceCollectioniin + SqlServer konffit
   - Jos tietokantaa ei sovelluksen käynnistyessä ole, sovellus luo sen
   - Jos tietokanta löytyy, sovellus tekee migraation (vie mahdolliset muutokset olemassa olevaan kantaan)
-  Luo tarvittavat repository-luokat, joissa tapahtuu kannan käpistely. Esim. UserRepository ja ContactRepository

## Links
[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

[.NET Core Web API + Entity Framework Core sample](http://www.mithunvp.com/aspnet-core-web-api-entity-framework-core/) (Hyvä esimerkki, sisältää koodit)

[Getting started by Microsoft](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro) (Tutoriaali MVC-mallin mukaan. Voi hyödyntää, kun ohittaa käyttöliittymään liittyvät jutut)

