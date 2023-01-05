import { Injectable } from '@angular/core';
import { OverlayContainer } from '@angular/cdk/overlay';

@Injectable({
    providedIn: 'root'
})
export class ThemeService {
    isLight = true;

    constructor(
        private overlay: OverlayContainer
    ) {
        this.isLight = window.matchMedia && window.matchMedia('(prefers-color-scheme: light)').matches;
        this.setOverlayContainerTheme();

        window.matchMedia('(prefers-color-scheme: light)')
            .addEventListener('change', (e: MediaQueryListEvent) =>
                this.toggleTheme(e.matches)
            );
    }

    toggleTheme = (light: boolean | null = null) => {
        this.isLight = light ?? !this.isLight;
        this.setOverlayContainerTheme();
    }

    private setOverlayContainerTheme = () => {
        if (this.isLight) {
            this.overlay.getContainerElement().classList.remove('app-dark');
            this.overlay.getContainerElement().classList.add('app-light');
        } else {
            this.overlay.getContainerElement().classList.remove('app-light');
            this.overlay.getContainerElement().classList.add('app-dark');
        }
    }
}