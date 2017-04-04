# contacts-app
Contacts-sovelluksen toteutus Angular 4:llä. Alla on esimerkit käyttöliittymästä ja tarvittavista luokista. UI:ta saa tuunata nätimmäksikin :)

<img src="https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/ng-contacts-app.png">
<br></br>
<img src="https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/ng-contacts-app-ui.png">


#### app.component
* Pyytää contacteja ContacServiceltä ja välittää ne ContactListComponentille
* Template sisältää ContactListin ja napin, jolla lisätään uusi contact (kutsuen ContactServiceä)
* Tarkkailee ContactListComponentilta tulevia eventtejä ja reagoi niihin
    * Muokkaa contact
    * Poista contact
    * Näytä contact kartalla

#### contact-list.component
* @Input() contacts: Contact[];
* @Output() editContact: EventEmitter<Contact>;
* @Output() removeContact: EventEmitter<Contact>;
* @Output() showContactOnMap: EventEmitter<Contact>;

#### contact-list-item.component
* @Input() contact: Contact;
* @Input() edit: EventEmitter<Contact>;
* @Input() remove: EventEmitter<Contact>;
* @Input() showOnMap: EventEmitter<Contact>;

#### contact.service
* Tarjoaa työkalut contactien varastoimiseen local storageen.

#### contact
* Luokka, josta muodostetaan contact-objecteja
    * id
    * firstName
    * lastName
    * phone
    * streetAddress
    * city


## Links
#### Dependencies
[Angular Material](https://material.angular.io/guide/getting-started)

[Flex-Layout](https://github.com/angular/flex-layout/wiki/Integration-with-Angular-CLI)

[Icons](https://www.flowdock.com/app/saimia/angular/threads/-iPsHaxZlakrRntO5ExYui-20Nz)

#### Flowdock
[angular-links flow](https://www.flowdock.com/app/saimia/angular/threads/MovuzqH73uqEZWWb_Do3g6phtpE)

[contacts-app flow](https://www.flowdock.com/app/saimia/angular/threads/0ArCwZmbIlxDVyzcCqeFD5aJChT)
(Täällä juttua harkkaan liittyen. Mm. ohjetta Angular Material Dialog-komponentin käytöstä)

