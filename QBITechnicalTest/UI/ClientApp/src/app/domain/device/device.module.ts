import { NgModule } from '@angular/core';
import {DevicePage} from "./pages/device/device.page";
import {DeviceRoutingModule} from "./device-routing.module";
import {QBIDeveloperTestCoreModule} from "../../core/core.module";

@NgModule({
    declarations: [
        DevicePage
    ],
    imports: [
      DeviceRoutingModule,
      QBIDeveloperTestCoreModule
    ]
})
export class DeviceModule {

}
