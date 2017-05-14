# contacts-app token based authentication

Harjoituksessa rakennetaan contacts-app sovellukseen tokeneihin pohjautuva [JWT (JSON Web Token) bearer autentikointi](https://andrewlock.net/a-look-behind-the-jwt-bearer-authentication-middleware-in-asp-net-core/). 

<img src="https://raw.githubusercontent.com/ekoodi/ekoodi.github.io/master/web-technologies/images/ng-contacts-app-authentication.png">
<br><br>

1. Käyttäjä kirjautuu sovellukseen käyttäjätunnuksella ja salasanalla.
2. Client kutsuu Web API:n authenticate-rajapintaa käyttäen käyttäjätunnusta ja salasanaa.
3. Server suorittaa autentikoinnin: Tarkistaa, että käyttäjä on se joka väittää olevansa. Eli tunnistaa käyttäjän käyttäjätunnuksen ja salasanan perusteella.
4. Server luo tokenin ja pitää sen itsellään tallessa. Tokenia käytetään käyttäjän tunnistamiseen kaikissa API-kutsuissa.
5. Server palauttaa tokenin clientille.
6. Client ottaa serverin palauttaman tokenin talteen.
7. Client kutsuu Web API:n kirjautumis-rajapintaa ja välittää tokenin HTTP-kutsun Authorization headerissa.
8. Clientin täytyy lähettää Authorization header kaikissa HTTP-kutsuissa.
9. Jos käyttäjän tunnistaminen ei onnistu (käyttäjätunnus+salasana / token ei ole validi), server palauttaa HTTP 401 Unauthorized.

#### Server

Esimerkki autentikoinnin rakentamiseen .NET Core Web API -projektiin löytyy vaikka [täältä](https://code.msdn.microsoft.com/How-to-authorization-914d126b). 
Ja Google auttaa myöskin :)

Bearer autentikoinnin ja authorization policyn konffaus Startup.cs-luokassa:

```
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build());
            });
            
            ...
            
            app.UseJwtBearerAuthentication(new JwtBearerOptions()
            {
                //TODO...
            });
```

Esimerkki Controllerista, joka on autentikoinnin takana

```
    [Route("api/user")]
    [Authorize("Bearer")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPut]
        public IActionResult Login()
        {
            var user = _userService.FindUserByUsername(User.Identity.Name);
            return new JsonResult(user);
        }
    }
```

#### Client

Angular-sovelluksessa Authorization headerin lisääminen HTTP-kutsuihin kannattaa tehdä keskitetysti yhdessä paikassa. 
Tämä kannattanee hoitaa tekemällä oma HttpService, joka periytetään Angularin Http:stä. 
Angular Http:n request-funktio ylikirjoitetaan siten, että ennen kutsun lähetystä, suoritetaan headerin lisäys.
 Aiheestä löytyy juttua [täältä](http://www.adonespitogo.com/articles/angular-2-extending-http-provider/).
 
 Omassa HttpServie:ssä voidaan myös Http-kutsuissa tapahtuneet virheet käsitellä keskitetysti yhdessä paikassa.
 
 ## Links
 
 [JWT bearer authentication in ASP.NET Core](https://andrewlock.net/a-look-behind-the-jwt-bearer-authentication-middleware-in-asp-net-core/)
 
 [Angular Custom HttpService](http://www.adonespitogo.com/articles/angular-2-extending-http-provider/)