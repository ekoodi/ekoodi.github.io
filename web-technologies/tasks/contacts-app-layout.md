# contacts-app layout and routes

## Things to do

<img src="https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/ng-contacts-app-sidenav.png">
<br><br>

1. Ota routet käyttöön sovelluksessasi (ohjeet videolla: https://www.youtube.com/watch?v=0zPrPoDQXdE)
2. Tee kirjautumissivu, jolta navigoidaan näkymään, jossa on lista kontakteista.
3. Lisää sovellukseen Angular Materialin [toolbar](https://material.angular.io/components/component/toolbar) ja [sidenav](https://material.angular.io/components/component/sidenav) komponentit. Toolbar ja sidenav ovat aina samat riippumatta siitä millä näytöllä ollaan. Tämän vuoksi ne kannattaa sijoittaa app-komponenttiin. Alla esimerkkiä app.component.html sisällöstä.

```html
<md-sidenav-container class="ca-sidenav-container">
  <md-sidenav class="ca-sidenav" #sidenav [mode]="sidenavMode" [opened]="sidenavMode == 'side'">
    Sidenav content
  </md-sidenav>
  <md-toolbar class="mat-elevation-z5" color="primary">
    Toolbar
  </md-toolbar>
  <div class="ca-app-container">
    <!--Angular router näyttää komponentit tässä-->
    <router-outlet></router-outlet>
  </div>
</md-sidenav-container>
```
4. Pyri rakentamaan käyttöliittymä siten, että se skaalautuu eri kokoisille näytöille. Esimerkiksi sidenav voi olla piilotettuna pienillä ruuduilla mutta auki isommilla. Tässä kannattaa hyödyntää [Angular Flex Layoutia](https://github.com/angular/flex-layout).
5. BONUS! Tutustu teemojen tuunaamiseen: https://www.flowdock.com/app/saimia/angular/threads/HxybafMVnCCCCb_XDtLt8R5PcI2


Harjoitusprojektin hakemistorakenne pitäisi alkaa näyttämään suunnilleen tällaiselta: 
https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/ng-contacts-app-project-structure.png


## Links
[Angular Flex Layout](https://github.com/angular/flex-layout)

[Angular Material](https://material.angular.io/components)

[Google Material Color Tool](https://material.io/color/#!/?view.left=0&view.right=0) (värien valitsemiseen)
