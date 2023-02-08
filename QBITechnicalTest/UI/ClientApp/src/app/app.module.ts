import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { QBIDeveloperTestAppRoutingModule } from './app-routing.module';
import { QBIDeveloperTestAppComponent } from './app.component';
import { QBIDeveloperTestCoreModule } from './core/core.module';
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";


@NgModule({
    declarations: [
        QBIDeveloperTestAppComponent
    ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        RouterModule,
        QBIDeveloperTestAppRoutingModule,
        QBIDeveloperTestCoreModule
    ],
    providers: [],
    bootstrap: [QBIDeveloperTestAppComponent]
})
export class QBIDeveloperTestAppModule { }
