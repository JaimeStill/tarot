import { Route } from '@angular/router';
import { MajorRoute } from './major';
import { MinorRoute } from './minor';
import { TarotRoute } from './tarot';

export const Routes = [
    MajorRoute,
    MinorRoute,
    TarotRoute
]

export const RoutePaths: Route[] = [
    { path: 'major/:name', component: MajorRoute },
    { path: 'minor/:name', component: MinorRoute },
    { path: '', component: TarotRoute },
    { path: '**', redirectTo: '', pathMatch: 'full' }
]
