import {
    Component,
    EventEmitter,
    Input,
    Output
} from '@angular/core';

import { TarotCard } from '../models';

@Component({
    selector: 'tarot-link',
    templateUrl: 'tarot-link.component.html',
    styleUrls: ['tarot-link.component.scss']
})
export class TarotLinkComponent {
    @Input() card!: TarotCard;
    @Input() cardStyle: string = 'bg-card border-divider rounded el6 m4 p2';
    @Output() view: EventEmitter<TarotCard> = new EventEmitter();
}
