import { TarotBase } from './tarot-base';
import { TarotElement } from './tarot-element';

export interface TarotSuit extends TarotBase {
    elementId: number;
    name: string;

    element: TarotElement;
}