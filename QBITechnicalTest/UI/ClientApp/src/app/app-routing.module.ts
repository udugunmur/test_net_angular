import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', loadChildren: async () => (await import('./domain/home/home.module')).QBIDeveloperTestHomeModule },
    { path: 'device', loadChildren: async () => (await import('./domain/device/device.module')).DeviceModule }
];


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class QBIDeveloperTestAppRoutingModule { }
