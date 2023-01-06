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

import { MajorTarotCard } from '../../models';

@Component({
    selector: 'major-route',
    templateUrl: 'major.route.html',
    providers: [TarotApi]
})
export class MajorRoute implements OnInit {
    card!: MajorTarotCard;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private tarot: TarotApi
    ) { }

    async ngOnInit(): Promise<void> {
        this.route.paramMap.subscribe(async (params: ParamMap) => {
            const name = params.get('name');

            name
                ? this.card = await this.tarot.getMajorByName(this.tarot.routeDecode(name))
                : this.router.navigate(['/']);
        })
    }
}
