import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Task } from '../../models/task.model';
import { QBIDeveloperTestHomeService } from '../../services/home.service';

@Component({
    selector: 'qbi-developer-test-home-page',
    templateUrl: 'home.page.html',
    styleUrls: ['home.page.scss']
})
export class QBIDeveloperTestHomePage implements OnInit {
    tasks$: Observable<Task[]> | undefined;

    constructor(
        private readonly QBIDeveloperTestHomeService: QBIDeveloperTestHomeService
    ) { }

    ngOnInit() {
        this.tasks$ = this.QBIDeveloperTestHomeService.getTasks();
    }
}