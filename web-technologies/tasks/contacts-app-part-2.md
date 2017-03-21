# contacts-app part-2
Jatkoa harkalle [contacts-app](https://github.com/ekoodi/ekoodi.github.io/blob/master/web-technologies/tasks/contacts-app.md).

Front-end (client)
* HTML, CSS, JavaScript
* jQuery

Back-end (server)
* C#
* REST API (C# Web API)

## Things to do

1. Tutustu yleisesti REST-rajapintoihin (esim. [REST API Tutorial](http://www.restapitutorial.com/)) ja kiinnitä huomiota erityisesti seuraaviin asioihin:
* HTTP metodien käyttö
* Palveluiden nimeäminen

2. Tutustu [jQueryyn](http://jquery.com/)

3. Muuta git-repositoryn hakemistorakennetta siten, että juuresta löytyy oma hakemistonsa sekä client-projektille että server-projektille. Clientin alle tulee nykyinen contacts-app toteutus ja serverin alle Web API.

4. Tee palvelu, joka REST-rajapinnan kautta
* Palauttaa kaikki yhteystiedot
* Tallentaa uuden yhteystiedon
* Päivittää yhteystiedon
* Poistaa yhteystiedon

Mallia Web API:n pystytykseen löytyy [täältä](https://github.com/santtone/web-api-sample).

Yhteystiedot voi olla jemmassa joko server-sovelluksen muistissa tai levylle kirjoitettavassa tekstitiedostossa.

5. Testaa, että tekemäsi palvelu toimii käyttäen jotakin HTTP-clientia. Chromeen asennettava [Postman](https://www.getpostman.com/) on hyvä ja kokeilemisen arvoinen. IntelliJ IDEA:n [omallakin](https://www.jetbrains.com/help/idea/2016.3/rest-client-tool-window.html) pärjää.

6. Lataa jQuery ja ota se käyttöön tekemässäsi contacts-app client-sovelluksessa.

7. Tee clientilta HTTP-kutsuja (jQuery auttaa tässä) tekemääsi palveluun:
* Hae käyttöliittymässä näytettävät yhteystiedot
* Lisää uusi yhteystieto
* Muokkaa/Poista yhteystieto

## Links
[REST API Tutorial](http://www.restapitutorial.com/)

[Build REST API](https://docs.microsoft.com/en-us/aspnet/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)

[Example of creating Web API using C# and Visual Studio (santtone)](https://github.com/santtone/web-api-sample)

[jQuery API](http://api.jquery.com/)
* [jQuery - Ajax](http://api.jquery.com/jQuery.ajax/#options)
* [jQuery - POST](http://api.jquery.com/jQuery.post/)
* [jQuery - GET](http://api.jquery.com/jQuery.get/)
