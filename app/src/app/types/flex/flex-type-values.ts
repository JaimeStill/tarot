export class FlexTypeValues {
    static fxAlign = [
        'baseline',
        'center',
        'end',
        'flex-end',
        'flex-start',
        'normal',
        'space-around',
        'space-between',
        'space-evenly',
        'start',
        'stretch'
    ] as const;

    static fxAlignSelf = [
        'auto',
        'baseline',
        'center',
        'end',
        'flex-end',
        'flex-start',
        'self-end',
        'self-start',
        'start',
        'stretch'
    ] as const;

    static fxCross = [
        'baseline',
        'center',
        'end',
        'flex-end',
        'flex-start',
        'normal',
        'start',
        'stretch'
    ] as const;

    static fxDirection = [
        'column',
        'column-reverse',
        'row',
        'row-reverse'
    ] as const;

    static fxMain = [
        'center',
        'end',
        'flex-end',
        'flex-start',
        'left',
        'normal',
        'right',
        'space-around',
        'space-between',
        'space-evenly',
        'start',
        'stretch'
    ] as const;

    static fxWrap = [
        'nowrap',
        'wrap',
        'wrap-reverse'
    ] as const;
}
