import {
    Routes,
    RoutePaths
} from './routes';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MaterialModule } from './material.module';
import { AppComponent } from './app.component';
import { Directives } from './directives';

@NgModule({
    declarations: [
        AppComponent,
        ...Directives,
        ...Routes
    ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        HttpClientModule,
        MaterialModule,
        RouterModule.forRoot(RoutePaths)
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
