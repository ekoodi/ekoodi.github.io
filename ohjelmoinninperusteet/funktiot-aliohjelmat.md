# Toteuta ohjelmat C# -ohjelmointikielellä

## 1. Käyttäjää pyydetään kirjoittamaan ohjelmalle 1 luku.
Funktio palauttaa annetun määrän tähtiä, jotka pääohjelma tulostaa näytölle.


Esim.

 *  Input: 3
 *  Vastaus: ***

Input: -2

Vastaus: Numero -2 ei ole salittu luku.


## 2. Kirjoita funktio minimi(), joka palauttaa arvonaan kahdesta annetusta luvusta pienemmän.

Luvut välitetään funktiolle parametrina.


##3. Kirjoita funktio, joka pyytää käyttäjältä luvun annetulta väliltä ja tarkastaa luvun kelpoisuuden.

Mikäli luku ei ole annetulta väliltä tai se ei ole numeraalinen, sitä pyydetään funktiossa uudelleen.
Funktio palauttaa käyttäjän syöttämän luvun. Funktiota kutsutaan seuraavasti:

luku=pyyda_luku_valilta(alaraja,ylaraja);

## 4. Kirjoita funktio, joka pyytää käyttäjältä 10 positiivista kokonaislukua ja palauttaa niistä suurimman.

 Funktiolle kelpaa syötteeksi vain positiiviset luvut.
Virheellisestä luvusta tulostetaan ilmoitus ja luku pyydetään uudestaan.

Esim.

    Input:
    Syötä 10 lukua
    1. 5
    2. 6
    3. 7
    4. 10
    5. 2
    6. 15
    7. -2
    Väärä syöte, syötä positiivinen luku
    7. -6
    Väärä syöte, syötä positiivinen luku
    7. 2
    8. 1
    9. 9
    10. 4


Output:

    Syötit seuraavat luvut
    5 6 7 10 2 15 2 1 9 4

Suurin 15 oli 6. luku
