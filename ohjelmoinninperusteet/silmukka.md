Toteuta ohjelmat C# -ohjelmointikielellä.

1. Tee ohjelma, joka tulostaa N! kertoman arvon eli
5! = 1*2*3*4*5
10! = 1*2*3*4*5*6*7*8*9*10
jne.
Ohjelman tulee tarkistaa, että N on vähintään 1
N:n arvo kysytään käyttäjältä.

Esim.
Input: 5
Vastaus: 120

Input: 0
Vastaus: 1

Input: -5
Vastaus: Määrittelemätön


2. Tee ohjelma, joka laskee N ensimmäistä lukua yhteen. 
N:n arvo kysytään käyttäjältä.

Ohjelman tulee tarkistaa, että N on vähintään 1

Esim.
Input: 10 (N=10 : 1+2+3+4+5+6+7+8+9+10=55)
Vastaus: 55

3. Tee ohjelma, joka laskee N:n ensimmäisen parittoman ja parillisen lukujen summan. 
N:n arvo kysytään käyttäjältä.

Esim.
Input: 10
Vastaus: Parittomien summa = 25, Parillisten summa = 30

N=10 : 1+3+5+7+9=25 ja 2+4+6+8+10=30

4. Muokkaa ohjelmaa 2 niin, että se laskee myös negatiivisilla numeroilla.

Esim.
Input: 10 (N=10 : 1+2+3+4+5+6+7+8+9+10=55)
Vastaus: 55

Input -10 [N=-10 : (-1)+(-2)+(-3)+(-4)+(-5)+(-6)+(-7)+(-8)+(-9)+(-10)=-55]
Vastaus: -55
 
5. Muokkaa ohjelmaa 3 niin, että se laskee myös negatiivisilla numeroilla.

Esim.
Input: 10
Vastaus: Parittomien summa = 25, Parillisten summa = 30

Input: -10
Vastaus: Parittomien summa = -25, Parillisten summa = -30

N=-10 : (-1)+(-3)+(-5)+(-7)+(-9)=-25 ja (-2)+(-4)+(-6)+(-8)+(-10)=-30

Satunnaisluvun arvonta tapahtuu seuraavasti:
Random rnd = new Random(); // Luodaan uusi ilmentymä rnd oliosta Random.

rnd.NextDouble(); metodi arpoo luvun 0...1 väliltä

rnd.Next(100); metodi arpoo kokonaisluvun 0 ja 100 väliltä ]0...100[


Toteuta seuraavat ohjelmat C# -ohjelmointikielellä.

6. Tee ohjelma, joka tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.

Luku     Neliöjuuri
 1          1.00
 2          1.41
 ...
 10         3.16

7. Tee ohjelma, joka tulostaa kertotaulun luvuille 1-9.

Vastaus:
1 x 1 = 1
1 x 2 = 2
...
9 x 9 = 81

8. Tee ohjelma, joka tulostaa 20 satunnaista kokonaislukua väliltä [0-50].
Tulosta luvut siten, että jokaisella rivillä on 5 lukua pilkulla erotettuna.

Vastaus:
Rivi 1: 25, 0, 32, 11, 15
Rivi 2: 10, 20, 17, 35, 22
...

9. Tee ohjelma, joka simuloi rahan heittoa seuraavasti: 
Ohjelma kysyy ensin heittojen lukumäärän n ja simuloi 
sitten rahan heittoa n kertaa (0=klaava, 1=kruuna). 
Lopuksi ohjelma tulostaa saatujen klaavojen ja kruunien määrän.

Vastaus:
Rahaa on heitetty 20 kertaa.
Klaavoja tuli 6 ja kruunuja 14.

10. Tee ohjelma, joka tulostaa vakioveikkauksen rivin (13 kohdetta, 
1 = kotivoitto, X = tasapeli ja 2 = vierasvoitto). Kotivoiton todennäköisyys on 0.4, tasapelin 0.2 ja vierasvoiton 0.4.

Ohjelmankulku
Aloitus
- Aloita silmukka
  - Arvo luku
  - Jos luku ]0-0.4[ =>Kotivoitto
    - Tulosta: Kotivoitto
  - muuten Jos luku ]0.4-0.6[ =>Tasapeli
    - Tulosta: Tasapeli
  - muuten =>Vierasvoitto
    - Tulosta: Vierasvoitto
- Silmukka päättyy
Lopetus

Vastaus esimerkki:
1. X
2. 1
3. 1
4. 2
5. 2
6. X
7. X
8. X
9. 2
10. 1
11. X
12. 2
13. 2

11. Tee ohjelma, joka simuloi nopanheittoa 1000 kertaa ja tulostaa 
lisäksi kuutosen esiintymiskertojen lukumäärän. 

Vastaus:
 1. 2
 2. 5
 3. 1
 4. 6
 ...
 1000. 2

Kuutonen arvottiin 328 kertaa.
