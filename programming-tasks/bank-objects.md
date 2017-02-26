# C# olio-ohjelmoinnin harkka

## Tarvittavat luokat:

Asiakas
- etunimi
- sukunimi
- tilinumero
- override ToString() (ylikirjoita luokan default ToString-metodi)

Pankki
- nimi
- tilit
- luo uusi tili (palauttaa uuden tilin tilinumeron)
- hae asiakkaan kaikki tilitapahtumat
- hae asiakkaan tilitapahtumat aikaväliltä
- hae asiakkaan tilin saldo
- lisää tilitapahtuma asiakkaan tilille

Pankkitili
- tilinumero
- tilitapahtumat
- saldo
- anna kaikki tilitapahtumat
- anna tilitapahtumat aikaväliltä
- anna saldo
- lisää tilitapahtuma

Tilitapahtuma
- aikaleima
- summa (+/-)

## Things to do

1. Toteuta yllä mainitut luokat. 
Kiinnitä huomiota seuraaviin asioihin: private vs public, propertyt, nimeämiskäytännöt. Lisää muuttujia ja metodeja tarpeen mukaan harjoituksen edetessä.
2. Luo pankki-olio.
3. Luo kolme asiakas-oliota.
4. Luo pankkiin jokaiselle asiakkaalle oma pankkitili. Pankkiin luodun tilin tilinumero palautetaan ja talletetaan asiakas-olion muuttujaan.
Tee tilinumerosta 18 merkkiä pitkä. Kaksi ensimmäistä merkkiä ovat 'FI'. Generoi loput merkit käyttäen C#:n Random-luokkaa.
5. Lisää pankkiin jokaisen asiakkaan tilille jokin summa rahaa luomalla tilille uusi/uusia tilitapahtumia. Käytä asiakkaalta löytyvää tilinumeroa, jotta tapahtumat kohdistuvat oikealle tilille.
6. Kysy pankista jokaisen asiakkaan tilin saldo ja tulosta asiakas (käytä asiakas-olion ToString()-metodia) sekä hänen saldonsa.
7. Kuluta asiakkaiden tileiltä rahaa luomalla pankkiin asiakkaiden tileille uusia tilitapahtumia eri aikaleimoilla ja negatiivisilla summilla.
8. Kysy ja tulosta jokaisen asiakkaan tilitapahtumat ja tilin saldo valitsemaltasi aikaväliltä. Käytä aikavälille osuvien tilitapahtumien etsimiseen LINQ-kyselyä.

## Aiheeseen liittyviä linkkejä

- [Object-Oriented Programming](https://msdn.microsoft.com/en-us/library/mt656686.aspx)
- [LINQ](https://msdn.microsoft.com/en-us/library/bb907066.aspx)
- [LINQ Methods] (https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods(v=vs.110).aspx)
- [Class](https://msdn.microsoft.com/en-us/library/x9afc042.aspx)
- [Properties](https://msdn.microsoft.com/en-us/library/x9fsa0sw.aspx)

--

- [Best Practices GitHub] (https://github.com/futurice/windows-app-development-best-practices)
- [Best Practices Microsoft MSDN] (https://msdn.microsoft.com/en-us/library/ms184412(v=vs.100).aspx)
