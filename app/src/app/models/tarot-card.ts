import { TarotAstrology } from './tarot-astrology';
import { TarotBase } from './tarot-base';
import { TarotElement } from './tarot-element';
import { TarotSuit } from './tarot-suit';

export interface TarotCard extends TarotBase {
    name: string;
    type: string;
    image: string;
    link: string;
    upright: string[];
    reversed: string[];
    isUpright: boolean;
}

export interface MajorTarotCard extends TarotCard {
    astrologyId: number;
    elementId: number;
    value: number;
    astrologyType: string;

    astrology: TarotAstrology;
    element: TarotElement;
}

export interface MinorTarotCard extends TarotCard {
    suitId: number;
    value: number;

    suit: TarotSuit;
}
