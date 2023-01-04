import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import { TarotPlanet } from '../../models';

@Injectable()
export class PlanetApi {
    private api: string = `${environment.api}planet/`;

    constructor(
        private http: HttpClient
    ) { }

    get = (): Promise<TarotPlanet[]> =>
        firstValueFrom(
            this.http.get<TarotPlanet[]>(`${this.api}get`)
        );

    getById = (id: number): Promise<TarotPlanet> =>
        firstValueFrom(
            this.http.get<TarotPlanet>(`${this.api}getById/${id}`)
        );
}