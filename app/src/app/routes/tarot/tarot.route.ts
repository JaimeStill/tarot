import {
    Component,
    OnInit
} from '@angular/core';

import { Router } from '@angular/router';
import { TarotCard } from '../../models';
import { TarotApi } from '../../services';

@Component({
    selector: 'tarot-route',
    templateUrl: 'tarot.route.html',
    styleUrls: ['tarot.route.scss'],
    providers: [TarotApi]
})
export class TarotRoute implements OnInit {
    deck: TarotCard[] = new Array<TarotCard>();

    constructor(
        private router: Router,
        private tarot: TarotApi
    ) { }

    async ngOnInit(): Promise<void> {
        this.deck = await this.tarot.get();
    }

    setWidth = (deckWidth: number) => Math.floor(deckWidth / 3);

    view = (card: TarotCard) => this.router.navigate([
        ...(this.tarot.routeEncode(card))
    ]);
}
