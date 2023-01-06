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
    selector: '[flexChild]'
})
export class FlexChildDirective implements OnChanges, OnInit {
    private readonly FLEX_DEFAULT = '0 1 auto';

    // align-self
    @Input() flexAlignSelf: FxAlignSelf = 'auto';
    // flex
    @Input() flex: string = this.FLEX_DEFAULT;

    @Input() canFlex: boolean = true;

    private style = () => this.el.nativeElement.style;

    private setFlex = () => this.style().flex =
        this.canFlex
            ? this.flex
            : this.FLEX_DEFAULT;

    constructor(private el: ElementRef) { }

    ngOnInit(): void {
        this.style().alignSelf = this.flexAlignSelf;
        this.setFlex();
    }

    ngOnChanges(changes: SimpleChanges): void {
        // align-self
        if (changes['flexAlignSelf'])
            this.style().alignSelf = this.flexAlignSelf;

        // flex
        if (changes['flex'])
            this.setFlex();

        if (changes['canFlex'])
            this.setFlex();
    }
}
