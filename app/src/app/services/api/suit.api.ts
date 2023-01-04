import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import {
    TarotElement,
    TarotSuit
} from '../../models';

@Injectable()
export class SuitApi {
    private api: string = `${environment.api}suit/`;

    constructor(
        private http: HttpClient
    ) { }

    get = (): Promise<TarotSuit[]> =>
        firstValueFrom(
            this.http.get<TarotSuit[]>(`${this.api}get`)
        );

    getById = (id: number): Promise<TarotSuit> =>
        firstValueFrom(
            this.http.get<TarotSuit>(`${this.api}getById/${id}`)
        );

    getByElement = (element: TarotElement): Promise<TarotSuit> =>
        firstValueFrom(
            this.http.post<TarotSuit>(`${this.api}getByElement`, element)
        );
}