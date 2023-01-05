import { Route } from '@angular/router';
import { TarotRoute } from './tarot';

export const Routes = [
    TarotRoute
]

export const RoutePaths: Route[] = [
    { path: '', component: TarotRoute },
    { path: '**', redirectTo: '', pathMatch: 'full' }
]
