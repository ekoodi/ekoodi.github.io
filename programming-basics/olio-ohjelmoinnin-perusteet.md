# C# olio-ohjelmoinnin perusteet

Tee luokka **Auto**, jolla on **(jäsen)muuttujina** merkki ja nopeus. 
Toteuta Auto -luokalle oletusmuodostin ja muodostin parametreilla (Constructor)
- oletusmuodostimessa asetetaan alkuarvot merkki ja nopeus muuttujille (vaikkapa Ford ja 80)
- muodostin paramatreilla

Auto -luokalla on **(jäsen)funktiona eli metodi** näytäTiedot().  
näytäTiedot() -metodi tulostaa käyttäjälle auton merkin ja nopeuden. 

Tee testeri, jossa luot vähintään kolme auto-oliota ja lähetät niille näytäTiedot() viestin.

Lisää Auto-luokkaan kiihdyta() -metodi, joka välittää **parametrinaan** nopeuden muutoksen ja 
lisää Auto olion nopeutta tällä muutoksella. Tee tarvittavat lisäykset testeriin ja näet Auto-olioiden uudet nopeudet.

Lisää Auto-luokkaan jarruta() -metodi, joka vähentää auton nopeutta 10%. Tee tarvittavat muutokset myös testeriin.

Sanasto:
Luokka = Class
Oletusmuodostin, muodostin = Constructor
Jäsenmuuttuja, muuttuja, attribuutti = Field, Variable, Attribute
Jäsenfunktio, funktio = Method
Ominaisuus = Property

## Tarvittava luokka:

luokka Auto
- merkki
- nopeus

oletusmuodostin()

muodostin(parametrit)

metodit
- näytäTiedot()
- kiihdytä()
- jarruta()


## Things to do

1. Toteuta yllä mainittu luokka. (Tee oma tiedosto)

2. Toteutan testeri, jossa luodaan auto-oliot. (Tee oma tiedosto)
Debugaa ohjelmaa ja totea luokan toiminta.


## Aiheeseen liittyviä linkkejä

- [Object-Oriented Programming](https://msdn.microsoft.com/en-us/library/mt656686.aspx)
- [Class](https://msdn.microsoft.com/en-us/library/x9afc042.aspx)
- [Properties](https://msdn.microsoft.com/en-us/library/x9fsa0sw.aspx)

--

- [Best Practices Microsoft MSDN] (https://msdn.microsoft.com/en-us/library/ms184412(v=vs.100).aspx)
