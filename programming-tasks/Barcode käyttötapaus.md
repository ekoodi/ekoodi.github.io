# Barcode

## Yleiskuvaus 

Toteutetaan virtuaaliviivakoodin luonti-ohjelma pankkiviivakoodi-oppaan (Finanssialan keskusliitto v.5.3) kuvauksen mukaisesti C#-ohjelmointikielellä.

## Laatija 

Mikko Laitinen, Risto Ilmaniemi, Pirjo Niilo-Rämä, Sini Makkonen

## Päiväys / Versio 

22.3.2017

## Prosessi 

Ohjelmoinnin perusteet

## Käyttäjäroolit 

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
      <td>Ohjelmoija/ testaaja</td>
      <td>Luku, kirjoitus, testaus, kääntäminen</td>
  </tr>
  <tr>
      <td>Rooli 2</td>
      <td>Opettaja</td>
      <td>Katselmointi</td>
  </tr>
  <tr>
      <td>Rooli 3</td>
      <td>Loppukäyttäjä</td>
      <td>Käyttäminen</td>
  </tr>
  </tbody>
</table>

## Esitiedot/ehdot 

* Työvälineet asennuttuna ja toimintakunnossa
* Tutustuttu ohjelmointiympäristöön
* Debuggaus hallinnassa
* Ylläpitosopimus

## Käyttötapauksen kuvaus

https://github.com/ekoodi/ekoodi.github.io/blob/master/programming-tasks/barcode.md


## Poikkeukset

### P1

Kääntäminen ei onnistu. <br>
Tarkista virheilmoitukset, ympäristö ja ohjelman mahdolliset muut virheet esim. syntaksi virheet.

### P2

Ohjelma kaatuu suoritettaessa. Tarkista virheilmoitukset ja syntaksi virheet.

### P3

Ohjelma ei reagoi käyttäjän antamiin komentoihin tai syötteisiin. Tarkista syntaksi virheet.

### P4 

Ohjelma tuottaa virheellisen viivakoodin. Tarkista ohjelman logiikka debuggaamalla ja lähtöarvot.

### P5

Ohjelmaan syötetyt arvot ovat virheelliset. Ohjelma palauttaa virheilmoituksen ja palaa alkuun. 
Käyttäjä on virheellinen, tarkista käyttäjä. 


## Lopputulos 

Ohjelma toimii virheettömästi ja tuottaa oikean virtuaaliviivakoodin. <br>
Ohjelma antaa virhetapauksessa käyttäjälle virheilmoituksen, joka sisältää jatko-ohjeet.

## Muut vaatimukset

* v1: Ohjelmointikäytännöt
* v2: Käytettävyys
* v3: Koodin ulkoasu ja luettavuus
* v4: Ohjelman ulkoasu vastaa määrittelyjä

## Käyttötiheys 

Ohjelmaa ajetaan laskutuspäivänä tai laskutuksen yheydessä, laskuja luotaessa, kaksi kertaa kuussa eräajona. <br>
Eräajo sisältää useita suorituskertoja.

## Muuta 

Ohjelman päivitysajankohdasta sovitaan erikseen. Päivitykset suoritetaan ylläpitosopimuksessa sovitun huoltoikkunan aikana.
