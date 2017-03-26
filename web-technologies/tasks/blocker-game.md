## Blocker game

HTML5, JavaScript, CSS

<img src="https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/blocker-game.png">


### Thing To Do
1. Aloita luomalla käyttöliittymä:
-	[Canvas elementti](https://www.w3schools.com/html/html5_canvas.asp)
-	Nappi, joka käynnistää pelin
-	Napit, joilla liikutellaan pelaajaa. Vaihtoehtoisesti liikuttelun voi hoitaa myös näppäimistön nuolinäppäimillä.

2. Luo pelaaja-objekti ja [piirrä](https://www.w3schools.com/tags/canvas_fillrect.asp) se canvas elementtiin. Objectilla on ainakin seuraavat propertyt: x, y, leveys, korkeus, väri. Propertyt kertovat kuinka pelaaja piirretään canvakselle.

3. Muuta pelaajan propertyä y käyttöliittymän ylös/alas painikkeilla (tai nuolinäppäimillä).

4. Piirrä pelaajan uusi sijainti canvas elementille. Käytä uudelleenpiirtämisessä apuna JavaScriptin setInterval funktiota, joka hoitaa pelaajan jatkuvan uudelleenpiirtämisen canvakselle. Huom! canvas täytyy tyhjentää ennen uudelleenpiirtämistä. Eli jokaisella kierroksella tapahtuu ensiksi tyhjennys ja sen jälkeen piirto.

5. Tee muuttuja (esim. frameCount), jonka arvoa kasvatetaan jokaisella intervallilla.

6. Luo tietyin väliajoin (esim. 200 intervallin eli frameCountin välein) lisää este-objekteja. Liikuta niitä jokaisen intervallin aikana kohti pelaajaa.

7. frameCount == käyttäjän keräämä pistemäärä. Päivitä käyttäjän keräämät pisteet näytölle jokaisella intervallilla.

8. Tarkista jokaisella intervallilla osuuko pelaaja esteeseen. Jos osuu  game over.


Lisähommat
- Tuunaa peliä hienommaksi: kehitä käyttöliittymää, pelikentälle tausta, pelaajan esitys kuvana jne.
- Lisää pelikentälle piste-objekteja, joita keräämällä pelaaja voi kasvattaa pistemääräänsä.

## Links
[Canvas](https://www.w3schools.com/graphics/canvas_drawing.asp)

[setInterval](https://www.w3schools.com/jsref/met_win_setinterval.asp)

