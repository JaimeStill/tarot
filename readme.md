# Tarot

Name | Status | URL
-----|--------|-----
API | [![Azure API - Build and Deploy](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-api.yml/badge.svg)](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-api.yml) | https://jps-tarot-api.azurewebsites.net/swagger
App |  [![Azure App - Build and Deploy](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-app.yml/badge.svg)](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-app.yml) | https://jps-tarot-app.azurewebsites.net/

> This project is a work in progress

* [App](#app)
* [Server](#server)
    * [Tarot API](#tarotapi)
    * [Tarot Schema](#tarotmodels)
    * [Tarot CLI](#tarotcli)
* [Rider Waite Tarot Images](#rider-waite-tarot-images)

## App

Azure Hosted App: https://jps-tarot-app.azurewebsites.net/

> In progress

**Desktop**
https://user-images.githubusercontent.com/14102723/211125037-22d20be3-d83a-49f3-9f0b-176ffaf78145.mp4

**Mobile**
https://user-images.githubusercontent.com/14102723/211125239-badefd96-210c-4618-978e-3f3a180b5be0.MOV

## Server
[Back to Top](#tarot)

### [Tarot.Api](./server/Tarot.Api)

Azure Hosted Endpoint: https://jps-tarot-api.azurewebsites.net/swagger

### [Tarot.Models](./server/Tarot.Models)

Tarot schema and logic.

**Schema**
* [`MajorTarotCard`](./server/Tarot.Models/Models/TarotCard.cs#L48)
* [`MinorTarotCard`](./server/Tarot.Models/Models/TarotCard.cs#L79)
* [`TarotAstrology`](./server/Tarot.Models/Models/TarotAstrology.cs)
* [`TarotElement`](./server/Tarot.Models/Models/TarotElement.cs)
* [`TarotModality`](./server/Tarot.Models/Models/TarotModality.cs)
* [`TarotPlanet`](./server/Tarot.Models/Models/TarotPlanet.cs)
* [`TarotPolarity`](./server/Tarot.Models/Enums/TarotPolarity.cs)
* [`TarotSuit`](./server/Tarot.Models/Models/TarotSuit.cs)

**Data**
* [MajorArcana](./server/Tarot.Models/Enums/Cards/MajorArcana.cs)
* [MinorArcana](./server/Tarot.Models/Enums/Cards/MinorArcana.cs)
    * [Cups](./server/Tarot.Models/Enums/Cards/Cups.cs)
    * [Pentacles](./server/Tarot.Models/Enums/Cards/Pentacles.cs)
    * [Swords](./server/Tarot.Models/Enums/Cards/Swords.cs)
    * [Wands](./server/Tarot.Models/Enums/Cards/Wands.cs)
* [Elements](./server/Tarot.Models/Enums/TarotElements.cs)
* [Modalities](./server/Tarot.Models/Enums/TarotModalities.cs)
* [Planets](./server/Tarot.Models/Enums/TarotPlanets.cs)
* [Suits](./server/Tarot.Models/Enums/TarotSuits.cs)
* [Zodiac](./server/Tarot.Models/Enums/TarotZodiacs.cs)

### [Tarot.Cli](./server/Tarot.Cli)

Demonstrates a simple 3 card draw for testing purposes.

**CLI Sample Output**
```
Past:
Card: The Sun
Orientation: Reversed
Element: Fire
Planet: Sun
Keywords: Negativity, Depression, Sadness
Image: https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/major-19.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/the-sun-meaning-major-arcana-tarot-card-meanings

Present:
Card: Page of Wands
Orientation: Reversed
Element: Fire
Zodiacs: Aries, Leo, Sagittarius
Keywords: Lack of Direction, Procrastination, Creating Conflict
Image: https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/wands-11.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/page-of-wands-meaning-tarot-card-meanings

Future:
Card: 5 of Swords
Orientation: Upright
Element: Air
Zodiacs: Gemini, Libra, Aquarius
Keywords: Unbridled Ambition, Win at All Costs, Sneakiness
Image: https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/swords-5.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/five-of-swords-meaning-tarot-card-meanings
```

## Rider Waite Tarot Images
[Back to Top](#tarot)

Rider Waite Tarot card images (350 x 600 px) are hosted in an Azure Blob Storage container: https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/

They can be accessed with the following convention:

```
https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/{suit}-{value}.jpg
```

Example:

**The Fool**

https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/major-0.jpg

![the fool](https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/major-0.jpg)

**3 of Swords**

https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/swords-3.jpg

![3 of swords](https://ishtarcollective.blob.core.windows.net/rider-waite-tarot/swords-3.jpg)
