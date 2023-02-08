import {NgModule} from '@angular/core';
import {BaseModule} from "../base.module/base.module";
import {MenuModule} from "primeng/menu";
import {TableModule} from "primeng/table";
@NgModule({
  imports: [
    BaseModule
  ],
  exports: [
    MenuModule,
    TableModule
  ]
})
export class UIModule {
}
