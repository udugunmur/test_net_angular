import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { QBIDeveloperTestCoreModule } from '../../core/core.module';
import { QBIDeveloperTestTaskComponent } from './components/task/task.component';
import { QBIDeveloperTestHomeRoutingModule } from './home-routing.module';
import { QBIDeveloperTestHomePage } from './pages/home/home.page';

@NgModule({
    declarations: [
        QBIDeveloperTestHomePage,
        QBIDeveloperTestTaskComponent
    ],
    imports: [
        CommonModule,
        QBIDeveloperTestCoreModule,
        QBIDeveloperTestHomeRoutingModule
    ]
})
export class QBIDeveloperTestHomeModule {

}