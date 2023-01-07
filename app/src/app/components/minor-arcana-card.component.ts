import {
    Component,
    Input,
    OnInit
} from '@angular/core';

import {
    MinorTarotCard,
    TarotZodiac
} from '../models';

import { ZodiacApi } from '../services';

@Component({
    selector: 'minor-arcana-card',
    templateUrl: 'minor-arcana-card.component.html',
    styleUrls: ['minor-arcana-card.component.scss'],
    providers: [ZodiacApi]
})
export class MinorArcanaCardComponent implements OnInit {
    zodiacs: TarotZodiac[] = new Array<TarotZodiac>();
    @Input() card!: MinorTarotCard;

    constructor(
        private zodiacApi: ZodiacApi
    ) { }

    async ngOnInit(): Promise<void> {
        this.zodiacs = await this.zodiacApi.getByElement(
            this.card.suit.element
        );
    }
}
