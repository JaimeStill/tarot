import { TarotAstrology } from './tarot-astrology';
import { TarotElement } from './tarot-element';
import { TarotModality } from './tarot-modality';
import { TarotPlanet } from './tarot-planet';

export interface TarotZodiac extends TarotAstrology {
    elementId: number;
    modalityId: number;
    rulerId: number;
    dates: string;
    positiveTraits: string[];
    negativeTraits: string[];

    element: TarotElement;
    modality: TarotModality;
    ruler: TarotPlanet;
}