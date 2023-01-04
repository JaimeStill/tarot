import { TarotBase } from './tarot-base';
import { TarotPolarity } from './tarot-polarity';

export interface TarotElement extends TarotBase {
    name: string;
    keywords: string[];

    polarity: TarotPolarity;
}