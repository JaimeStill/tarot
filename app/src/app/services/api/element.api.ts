import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import { TarotElement } from '../../models';

@Injectable()
export class ElementApi {
    private api: string = `${environment.api}element/`;

    constructor(
        private http: HttpClient
    ) { }

    get = (): Promise<TarotElement[]> =>
        firstValueFrom(
            this.http.get<TarotElement[]>(`${this.api}get`)
        );

    getById = (id: number): Promise<TarotElement> =>
        firstValueFrom(
            this.http.get<TarotElement>(`${this.api}getById/${id}`)
        );
}