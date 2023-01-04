import { TarotBase } from './tarot-base';

export interface TarotAstrology extends TarotBase {
    type: string;
    name: string;
    keywords: string[];
}