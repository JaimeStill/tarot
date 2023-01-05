# Tarot

[![jps-tarot-api - Azure Web App Build and Deploy](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-api.yml/badge.svg)](https://github.com/JaimeStill/tarot/actions/workflows/main_jps-tarot-api.yml)

> This project is a work in progress

* [App](#app)
* [Server](#server)
    * [Tarot API](#tarotapi)
    * [Tarot Schema](#tarotmodels)
    * [Tarot CLI](#tarotcli)
* [Rider Waite Tarot Images](#rider-waite-tarot-images)

## App

> In progress

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
Card: 2 of Pentacles
Orientation: Reversed
Element: Earth
Zodiacs: Taurus, Virgo, Capricorn
Keywords: Loss of Balance, Disorganized, Overwhelmed
Image: https://cdn.shopify.com/s/files/1/1325/0879/files/two-of-pentacles-meaning-rider-waite-tarot_large.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/two-of-pentacles-meaning-tarot-card-meanings

Present:
Card: Queen of Wands
Orientation: Upright
Element: Fire
Zodiacs: Aries, Leo, Sagittarius
Keywords: Courage, Determination, Joy
Image: https://cdn.shopify.com/s/files/1/1325/0879/files/queen-of-wands-rider-waite-tarot_large.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/queen-of-wands-meaning-tarot-card-meanings

Future:
Card: 5 of Wands
Orientation: Reversed
Element: Fire
Zodiacs: Aries, Leo, Sagittarius
Keywords: Avoiding Conflict, Respect Differences
Image: https://cdn.shopify.com/s/files/1/1325/0879/files/5-of-wands-rider-waite-tarot_large.jpg
Link: https://labyrinthos.co/blogs/tarot-card-meanings-list/five-of-wands-meaning-tarot-card-meanings
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