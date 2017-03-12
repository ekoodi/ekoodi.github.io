##Laadi C# -ohjelma mäenlaskun pistelaskentaan. Toteuta graafinen käyttöliittymä haluamallasi tavalla.
Mieti millaista tietoa järjestelmään tarvitaan etukäteen ja mitä kilpailun aikana. Kilpailun edetessä pisteet lasketaan oheisen kuvauksen mukaisesti. 

**Tulokset** ilmoitetaan parhaan tulos ensin jne.

###Hypyn pituus

Jokaisella mäellä on oma K-pisteensä (kriittinen piste), joka kertoo mäen kokoluokan. Suurmäeksi luokitellaan mäet, joissa K-piste on yli 100 metriä. Lahden suurmäessä se on 116 metriä. K-pisteeseen yltäneestä hypystä saa aina 60 pituuspistettä. K-pisteen ylittäminen tuo lisäpisteitä, ja sen alle jääminen johtaa puolestaan pistevähennyksiin. Hyvityksen ja vähennyksen suuruus vaihtelee mäen koon mukaan (pienemmässä mäessä suhteessa suurempi kuin isommassa mäessä), ja esimerkiksi suurmäessä se on 1,8 pistettä metriä kohden.

**Esimerkki:** Hyppääjä A ponkaisee Lahden suurmäestä 124 metriä. Hän saa automaattiset 60 pistettä K-pisteen ylittämisestä ja lisäksi hyvitystä kahdeksasta lisämetristä: 60 + 8 x 1,8 = 74,4 pistettä.

###Hypyn tyyli

Tyylipisteet määräytyvät ilmalennon, alastulon ja sitä seuraavan loppuliun kokonaisuutena. Arvostelijoina toimii viisi tuomaria, mutta hyppääjän tyylipisteisiin ei lasketa eniten ja vähiten pisteitä antaneiden tuomareiden pisteitä. Virheettömästä suorituksesta saa 20 pistettä kultakin tuomarilta, joten hyppääjän maksimityylipisteet ovat 60.

**Esimerkki:** Hyppääjä A saa tuomareilta tyylipisteet kerran 18, kaksi kertaa 18,5 ja kaksi kertaa 19. Heikoin (18) ja paras (19) pistemäärä poistetaan, joten tyylipisteet ovat: 18,5 + 18,5 + 19 = 56.

###Tuulihyvitys/-vähennys

Kunkin hypyn aikana tuuli mitataan viidestä kohdasta, joiden avulla lasketaan keskiarvo tuulen suunnalle ja voimakkuudelle. Hyppääjälle annetaan takatuulesta hyvitysmetrejä ja vastatuulesta puolestaan tehdään vähennyksiä. Vähennyksen tai hyvityksen kokoon vaikuttavat tuulen voimakkuus ja mäen K-piste seuraavan kaavan mukaan:

Tuulen vaikutus hypyn pituuteen = Tuulen voimakkuuden keskiarvo x (K-piste - 36)/20

**Esimerkki:** Hyppääjä A:n 124 metrin hypyn aikana puhalsi 1,4 metrin takatuuli. Hän saa siis hyvitysmetrejä seuraavanlaisesti: 1,4 x (116 - 36)/20 = 5,6. Metrimäärä pyöristetään puolen metrin tarkkuudella eli tässä tapauksessa 5,5 metriin. Pisteiksi muutettuna se tekee 1,8 x 5,5 = 9,9.

###Lähtölavahyvitys/-vähennys

Lähtölavaa voidaan nykyään muuttaa kesken hyppykierroksen. Hyppääjä saa hyvitysmetrejä jos hän lähtee suoritukseensa kilpailun aloituslavaa alempaa ja puolestaan vähennyksiä lähtiessään ylempää. Hyvityksen tai vähennyksen suuruus vaihtelee mäen koon mukaan, mutta esimerkiksi suurmäessä metrin muutos vauhdinotossa on katsottu vastaavan viittä metriä hypyn pituudessa.

**Esimerkki:** Hyppääjä A lähtee suoritukseensa 1,4 metriä ylempää kuin mistä kilpailu aloitettiin. Tällöin hänen hypyn pituudesta vähennetään 1,4 x 5 metriä = 7 metriä. Pisteinä se on 1,8 x 7 = 12,6.

Vihdoinkin kisaorganisaatio on valmis paljastamaan hyppääjä A:n hirmuloikan kokonaispisteet: 74,4 + 56 + 9,9 - 12,6 = 127,7.

Ja mäkimonttu riehaantuu!

**Lähde:**

www.fis-ski.com

---
**Ja koko ylläoleva taitaapi olla napsaistu täältä:**

http://www.ess.fi/urheilu/hiihtolajit/2013/03/06/ja-kokonaispisteet-ovat-nain-sujuu-makihypyn-pistelasku
