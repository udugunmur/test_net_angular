import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { QBIDeveloperTestContentComponent } from './components/content/content.component';
import { QBIDeveloperTestHeaderComponent } from './components/header/header.component';
import { QBIDeveloperTestMenuComponent } from './components/menu/menu.component';

@NgModule({
    declarations: [
        QBIDeveloperTestMenuComponent,
        QBIDeveloperTestHeaderComponent,
        QBIDeveloperTestContentComponent
    ],
    imports: [
        CommonModule,
        RouterModule,
        HttpClientModule
    ],
    exports: [
        QBIDeveloperTestMenuComponent,
        QBIDeveloperTestHeaderComponent,
        QBIDeveloperTestContentComponent
    ]
})
export class QBIDeveloperTestCoreModule {

}