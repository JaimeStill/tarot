import {
    Component,
    Input,
    OnInit
} from '@angular/core';

import {
    MajorTarotCard,
    TarotAstrology,
    TarotPlanet,
    TarotZodiac
} from '../models';

import {
    PlanetApi,
    ZodiacApi
} from '../services';

@Component({
    selector: 'major-arcana-card',
    templateUrl: 'major-arcana-card.component.html',
    styleUrls: ['major-arcana-card.component.scss'],
    providers: [
        PlanetApi,
        ZodiacApi
    ]
})
export class MajorArcanaCardComponent implements OnInit {
    planet!: TarotPlanet;
    zodiac!: TarotZodiac;

    @Input() card!: MajorTarotCard;

    constructor(
        private planetApi: PlanetApi,
        private zodiacApi: ZodiacApi
    ) { }

    async ngOnInit(): Promise<void> {
        switch (this.card.astrologyType.toLowerCase()) {
            case 'planet':
                this.planet = await this.planetApi.getById(this.card.astrologyId);
                break;
            case 'zodiac':
                this.zodiac = await this.zodiacApi.getById(this.card.astrologyId);
        }
    }
}
