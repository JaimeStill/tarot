import {
    Component,
    OnInit
} from '@angular/core';

import {
    ActivatedRoute,
    ParamMap,
    Router
} from '@angular/router';

import {
    TarotApi
} from '../../services';

import { MinorTarotCard } from '../../models';

@Component({
    selector: 'minor-route',
    templateUrl: 'minor.route.html',
    providers: [TarotApi]
})
export class MinorRoute implements OnInit {
    card!: MinorTarotCard;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private tarot: TarotApi
    ) { }

    async ngOnInit(): Promise<void> {
        this.route.paramMap.subscribe(async (params: ParamMap) => {
            const name = params.get('name');

            name
                ? this.card = await this.tarot.getMinorByName(this.tarot.routeDecode(name))
                : this.router.navigate(['/']);
        })
    }
}
