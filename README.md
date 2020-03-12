# Water Level Controller - Önálló Laboratórium

## Bevezetés
Feladatomnak egy mezőgazdaságban használatos automatizált jószág itató rendszer megtervezését és kivitelezését tűztem ki. Egyik ismerősöm megkeresése és problémájának felvázolása hozta az ötletet, hogy megvalósítsam ezt a projektet. Fontos szempont, hogy a vezérléshez ne legyen szükség vezetékes hálózatra, hiszen ennek való életben rengeteg korlátja van.

Az itatóban található vízszint mérőt ESP8266 típusú mikrokontrollerrel és a víz szabályozását Sonof kapcsolóval (ami szintén ESP8266 microchipet tartalmaz) gondoltam kivitelezni.
## Szoftver
#### Technológia
A .NET Core alapú szoftver két nagy részből épül fel:

    - Backend: A szenzorok és a kapcsolók vezérlését végzi.
    - Frontend: A felhasználók számára a böngészőből történő eszközök vezérlését végzi.
#### Az adatbázis diagramja

![](DatabaseDiagram.PNG)

#### Magyarázat:
- Sensors: `Itt tároljuk a itatóban lévő vízszintmérő eszközt.`

- Switches: `Itt tároljuk azokat az eszközöket, amely a víz adagolásáért felelős, valamilyen vízforráshoz csatlakozik. (Lehet az: kútban lévő búvárszivattyú vagy elektromos vízszelep.)`

- Scehdules: `Itt tároljuk az egyes eszközökhöz rendelt ütemezéseket, lehet az itató újratöltése automatikus, amely a MinWaterLevel értékben megadott küszöbszint alapján dönt, illetve lehet kézi, ha az Auto értéke false.`

- Ranches: `Itt tároljuk az egyes címeket/telephelyeket, amik egy-egy farmot/tanyát/egyéb ingatlant határoznak meg.`

- Users: `Itt találhatóak a felhasználók, akik több Ranches is hozzá lehetnek rendelve.`

- UserRanches: `Ez egy many-to-many kapcsolatot megvalósító tábla, mivel egy User-nek lehet több hozzáférése Ranch-ekhez, illetve egy-egy Ranch-hez több User is hozzáférhet.`