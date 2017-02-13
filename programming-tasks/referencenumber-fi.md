##Tee C#-ohjelma:
### 1. joka tarkastaa kotimaisen viitenumeron
### 2. luo kotimaisen viitenumero
### 3. luo halutun määrän kotimaisia viitenumeroita

Tutustu Finassialan Keskusliiton oppaaseen
http://www.finanssiala.fi/maksujenvalitys/dokumentit/kotimaisen_viitteen_rakenneohje.pdf

__esim. 1.__

- input: 12345672
- output: 123 45672 - OK

--
- input: 12345673
- output: Referencenumber Incorrect

--

__esim. 2.__
- input: 1234567
- output: 123 45672

--

__esim. 3.__

__input:__

Referencenumber basepart: 123456

Amount of referencenumbers: 10

__output:__

Counted referencenumbers:

1. 123 45614
2. 123 45627
3. 123 45630
4. 123 45643
5. 123 45656
6. 123 45669
7. 123 45672
8. 123 45685
9. 123 45698
10. 1234 56104
