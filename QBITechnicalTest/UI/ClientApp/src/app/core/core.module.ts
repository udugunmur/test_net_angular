import { NgModule } from '@angular/core';
import { QBIDeveloperTestContentComponent } from './components/content/content.component';
import { QBIDeveloperTestHeaderComponent } from './components/header/header.component';
import { QBIDeveloperTestMenuComponent } from './components/menu/menu.component';
import {BaseModule} from "../shared/base.module/base.module";
import {UIModule} from "../shared/ui.module/ui.module";

@NgModule({
    declarations: [
        QBIDeveloperTestMenuComponent,
        QBIDeveloperTestHeaderComponent,
        QBIDeveloperTestContentComponent
    ],
    imports: [
      BaseModule,
      UIModule,
    ],
    exports: [
        QBIDeveloperTestMenuComponent,
        QBIDeveloperTestHeaderComponent,
        QBIDeveloperTestContentComponent
    ]
})
export class QBIDeveloperTestCoreModule {

}
