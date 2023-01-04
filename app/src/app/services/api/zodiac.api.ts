import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import {
    TarotElement,
    TarotModality,
    TarotPlanet,
    TarotZodiac
} from '../../models';

@Injectable()
export class ZodiacApi {
    private api: string = `${environment.api}zodiac/`;

    constructor(
        private http: HttpClient
    ) { }

    get = (): Promise<TarotZodiac[]> =>
        firstValueFrom(
            this.http.get<TarotZodiac[]>(`${this.api}get`)
        );

    getById = (id: number): Promise<TarotZodiac> =>
        firstValueFrom(
            this.http.get<TarotZodiac>(`${this.api}getById/${id}`)
        );

    getByElement = (element: TarotElement): Promise<TarotZodiac> =>
        firstValueFrom(
            this.http.post<TarotZodiac>(`${this.api}getByElement`, element)
        );

    getByModality = (modality: TarotModality): Promise<TarotZodiac> =>
        firstValueFrom(
            this.http.post<TarotZodiac>(`${this.api}getByModality`, modality)
        );

    getByRuler = (ruler: TarotPlanet): Promise<TarotZodiac> =>
        firstValueFrom(
            this.http.post<TarotZodiac>(`${this.api}getByRuler`, ruler)
        );
}