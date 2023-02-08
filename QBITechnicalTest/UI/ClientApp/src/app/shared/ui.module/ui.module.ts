import {NgModule} from '@angular/core';
import {BaseModule} from "../base.module/base.module";
import {MenuModule} from "primeng/menu";
@NgModule({
  imports: [
    BaseModule
  ],
  exports: [
    MenuModule
  ]
})
export class UIModule {
}
