import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { QBIDeveloperTestHomePage } from './pages/home/home.page';

const routes: Routes = [
    { path: '', component: QBIDeveloperTestHomePage }
];


@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class QBIDeveloperTestHomeRoutingModule { }