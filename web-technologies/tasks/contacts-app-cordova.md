# contacts-app cordova

Jatkoa contacts-app sovellukselle. Harjoituksessa web-sovelluksesta tehdään Android-appi eli tuotetaan hybridisovellus. 

<img src="https://cordova.apache.org/static/img/guide/cordovaapparchitecture.png">

## Things to do

- Tutustu [Cordovaan]((https://cordova.apache.org/)).
- Asenna Android Studio ja Android SDK
- Luo Cordova-projekti olemassa olevaan repositoryyn. Tämän jälkeen repon juuressa client+server+cordova.
- Lisää Cordova-projektiin Android-platform.
- Tee contacts-sovelluksesta build.
- Kopioi buildattu sovellus (dist-kansion sisältö) Cordova-projektin www-hakemistoon.
- Käynnistä sovellus joko laitteella tai emulaattorissa.

### Lisähommaa

##### Crosswalk
- Tutustu [Crosswalkiin](https://crosswalk-project.org/)
- Asenna Cordova-sovellukseen Crosswalk-plugin

##### Cordova-plugin-vibration + Angular @Directive
- Lue dokumentaatiot [Vibration-plugari](https://cordova.apache.org/docs/en/latest/reference/cordova-plugin-vibration/index.html) ja [Angular attribute directive](https://angular.io/docs/ts/latest/guide/attribute-directives.html)
- Tee Angular directive, joka
    * Voidaan liittää attribuuttina sovelluksen button-elementteihin
    * Kuuntelee napin clickejä
    * Kutsuu vibra-plugaria aina, kun click tapahtuu
    
    
### Komentoja 
```
Angular CLI build
ng build --base-href .

Cordova CLI asennus
npm install -g cordova

Uusi cordova projekti
cordova create cordova com.ekoodi.contactsapp ContactsApp

Android-platformin lisäys projektille
cordova platform add android@6.2.1

Deploy laitteelle + run
cordova run android

Koneeseen liitettyjen Android-laitteiden listaus (pitää suorittaa ennen ensimmäistä run-komentoa)
adb devices

Testaus emulaattorissa, jos Android-laitetta ei ole saatavilla
cordova emulate android
```

## Links
[Android Studio ja Android SDK](https://developer.android.com/studio/index.html)

[Cordova](https://cordova.apache.org/)

[Cordova-projektin luonti](https://cordova.apache.org/docs/en/latest/guide/cli/index.html)

[Cordova + Crosswalk](https://crosswalk-project.org/documentation/cordova.html)

[Flow](https://www.flowdock.com/app/saimia/angular/threads/s5nQbmV6-iC2S9uTNWSa0EZTYpu)
