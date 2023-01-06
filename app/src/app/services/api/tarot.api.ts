import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import {
    MajorTarotCard,
    MinorTarotCard,
    TarotCard,
    TarotSuit
} from '../../models';

@Injectable()
export class TarotApi {
    private api: string = `${environment.api}tarot/`;

    constructor(
        private http: HttpClient
    ) { }

    routeEncode = (card: TarotCard): [ string, string ] => ([
        card.type.toLowerCase(),
        card.name.toLowerCase().replaceAll(' ', '-')
    ]);

    routeDecode = (name: string): string =>
        name.replaceAll('-', ' ');

    get = (): Promise<TarotCard[]> =>
        firstValueFrom(
            this.http.get<TarotCard[]>(`${this.api}get`)
        );

    getShuffled = (shuffles: number | null): Promise<TarotCard[]> => {
        const url = new URL(`${this.api}getShuffled`);

        if (shuffles && shuffles > 0)
            url.searchParams.append('shuffles', shuffles.toString());

        return firstValueFrom(
            this.http.get<TarotCard[]>(url.toString())
        )
    }

    getMajorArcana = (): Promise<MajorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MajorTarotCard[]>(`${this.api}getMajorArcana`)
        );

    getMinorArcana = (): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MinorTarotCard[]>(`${this.api}getMinorArcana`)
        );

    getCups = (): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MinorTarotCard[]>(`${this.api}getCups`)
        );

    getPentacles = (): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MinorTarotCard[]>(`${this.api}getPentacles`)
        );

    getSwords = (): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MinorTarotCard[]>(`${this.api}getSwords`)
        );

    getWands = (): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.get<MinorTarotCard[]>(`${this.api}getWands`)
        );

    getMajorCard = (id: number): Promise<MajorTarotCard> =>
        firstValueFrom(
            this.http.get<MajorTarotCard>(`${this.api}getMajorCard/${id}`)
        );

    getMajorByName = (name: string): Promise<MajorTarotCard> =>
        firstValueFrom(
            this.http.get<MajorTarotCard>(`${this.api}getMajorByName/${name}`)
        );

    getMinorCard = (id: number): Promise<MinorTarotCard> =>
        firstValueFrom(
            this.http.get<MinorTarotCard>(`${this.api}getMinorCard/${id}`)
        );

    getMinorByName = (name: string): Promise<MinorTarotCard> =>
        firstValueFrom(
            this.http.get<MinorTarotCard>(`${this.api}getMinorByName/${name}`)
        );

    getBySuit = (suit: TarotSuit): Promise<MinorTarotCard[]> =>
        firstValueFrom(
            this.http.post<MinorTarotCard[]>(`${this.api}getBySuit`, suit)
        );
}
