# KÄYTTÖTAPAUKSEN NIMI 

esim. Asiakastietojen muutos

## Yleiskuvaus 

Kuvataan lyhyesti mikä on käyttötapauksen tarkoitus/ tehtävä.
Esim. Käyttäjä lisää, muuttaa tai poistaa tietoja

## Laatija 

Kirjataan laatijan nimi.

## Päiväys / Versio 

Kirjataan laatimispäivä ja versio.

## Prosessi 

Kuvataan mihin prosessiin käyttötapaus kuuluu.
Esim. Asiakastietojen käsittelyprosessi.

## Käyttäjäroolit 

Kuvataan käyttötapauksen käyttäjäroolit

<table>
  <thead>
  <tr>
     <th>Rooli</th>
     <th>Kuvaus</th>
     <th>Oikeudet</th>
  </tr>
  </thead>
  <tbody>
  <tr>
      <td>Rooli 1</td>
      <td>Peruskäyttäjä</td>
      <td>Luku</td>
  </tr>
  <tr>
      <td>Rooli 2</td>
      <td>Tehokäyttäjä</td>
      <td>Luku/Kirjoitus</td>
  </tr>
  <tr>
      <td>Rooli 3</td>
      <td>Pääkäyttäjä</td>
      <td>Kaikki oikeudet</td>
  </tr>
  </tbody>
</table>

## Esitiedot/ehdot 

Kuvataan käyttötapauksen esiehdot, kuten esim. mitä järjestelmä tietää, mitä
tietoja järjestelmä tarvitsee, mitä pitää olla tehtynä, mitä käyttötapaus olettaa,
missä tilassa järjestelmä on, jotta käyttötapaus voidaan suorittaa.
Esim. Käsittelijä on kirjautunut järjestelmään omilla tunnuksillaan. Käsittelijä
on syöttänyt asiakasnumeron järjestelmään. Järjestelmä on hakenut asiakkaan
tiedot asiakastietokannasta ja avannut ne käsittelijälle.

## Käyttötapauksen kuvaus

1. Esim. Käsittelijä syöttää ja tallentaa asiakkaan uudet osoitetiedot järjestelmään.
1. Esim. Järjestelmä tarkistaa osoitetietojen oikeellisuuden (muodollinen tarkistus).
1. Esim.Järjestelmä hakee yleisrekisterijärjestelmästä (esim VTJ) asiakkaan osoitetiedot. Järjestelmä vertailee osoitetietoja. (P1)
1. Esim. Järjestelmä tallentaa hyväksytyt osoitetiedot kantaan ja ilmoittaa käyttäjälle tietojen
tallennuksen onnistumisesta.


## Poikkeukset

### P1

Esim. P1 Järjestelmä ilmoittaa käyttäjälle, että tiedoissa on eroja. Järjestelmä
näyttää käyttäjän syöttämät ja yleisrekisterijärjestelmästä saadut tiedot rinnakkain
käsittelijän ruudulla.

HUOM! Poikkeukset numeroidaan ja kukin sijoitetaan omaan ”lokeroon” ”, jotta
niihin voidaan viitata tekstikuvauksesta. (Esim. P1)

Poikkeukseen kirjoitetaan vain poikkeus, ei tilannetta/käsittelysääntöä, joka johtaa
poikkeukseen, ne on kirjoitettu tekstikuvaukseen tai tarvittaessa käsittelysääntöön.
Oletusarvoisesti käyttötapauksen suoritus keskeytyy poikkeukseen. Jos ei, siitä on
mainittava. 

### P2 

Voidaan lisätä ...

## Lopputulos 

Kuvataan mikä on käyttötapauksen lopputulos.
Esim. Asiakkaan tietoja on päivitetty. Tiedot on tallennettu tietokantaan.
Asiakkaalle on lähetetty vahvistus tietojen päivittämisestä.

## Muut vaatimukset

* v1: Kuvataan mitä muita vaatimuksia käyttötapaukselle asetetaan toiminnallisten vaatimusten lisäksi. Esim. Asiakastietojen haku perustietorekisteristä ei saa kestää yli 25 sek.
* v2:
* v3:

## Käyttötiheys 

Kuvataan, kuinka usein käyttötapausta suoritetaan.
Esim. Muutoksia tehdään n.100/päivässä

## Muuta 

Kuvataan muita käyttötapaukseen liittyviä oleellisia tietoja, kuten avoimia asioita, 
