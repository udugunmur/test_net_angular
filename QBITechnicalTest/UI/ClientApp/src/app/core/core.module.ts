import { NgModule } from '@angular/core';
import { QBIDeveloperTestContentComponent } from './components/content/content.component';
import { QBIDeveloperTestHeaderComponent } from './components/header/header.component';
import { QBIDeveloperTestMenuComponent } from './components/menu/menu.component';
import {BaseModule} from "../shared/base.module/base.module";
import {UIModule} from "../shared/ui.module/ui.module";
import {TransformNamePipe} from "./pipes/transformName.pipe";

@NgModule({
    declarations: [
        QBIDeveloperTestMenuComponent,
        QBIDeveloperTestHeaderComponent,
        QBIDeveloperTestContentComponent,
      TransformNamePipe
    ],
    imports: [
      BaseModule,
      UIModule,
    ],
  exports: [
    BaseModule,
    UIModule,
    QBIDeveloperTestMenuComponent,
    QBIDeveloperTestHeaderComponent,
    QBIDeveloperTestContentComponent,
    TransformNamePipe
  ]
})
export class QBIDeveloperTestCoreModule {

}
