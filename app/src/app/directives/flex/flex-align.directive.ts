import {
    Directive,
    ElementRef,
    Input,
    OnChanges,
    OnInit,
    SimpleChanges
} from '@angular/core';

import { FxAlignSelf } from '../../types/flex';

@Directive({
    selector: '[flexAlign]'
})
export class FlexAlignDirective implements OnChanges, OnInit {
    @Input() flexAlign: FxAlignSelf = 'auto';

    private style = () => this.el.nativeElement.style;

    constructor(private el: ElementRef) { }

    ngOnInit(): void {
        this.style().alignSelf = this.flexAlign || 'auto';
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['flexAlign'])
            this.style().alignSelf = this.flexAlign;
    }
}
