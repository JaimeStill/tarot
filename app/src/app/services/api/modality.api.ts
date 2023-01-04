import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

import { environment } from '../../../environments/environment';

import { TarotModality } from '../../models';

@Injectable()
export class ModalityApi {
    private api: string = `${environment.api}modality/`;

    constructor(
        private http: HttpClient
    ) { }

    get = (): Promise<TarotModality[]> =>
        firstValueFrom(
            this.http.get<TarotModality[]>(`${this.api}get`)
        );

    getById = (id: number): Promise<TarotModality> =>
        firstValueFrom(
            this.http.get<TarotModality>(`${this.api}getById/${id}`)
        );
}