import {
    Directive,
    ElementRef,
    Input,
    OnChanges,
    SimpleChanges
} from '@angular/core';

@Directive({
    selector: '[flex]'
})
export class FlexDirective implements OnChanges {
    private readonly FLEX_DEFAULT: string = '1 1 auto';

    @Input() flex!: string;

    private style = () => this.el.nativeElement.style;

    private setFlex = () => {
        this.style().flex = this.flex || this.FLEX_DEFAULT;
    }

    constructor(private el: ElementRef) { }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['flex'])
            this.setFlex();
    }
}
