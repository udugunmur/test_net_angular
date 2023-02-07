import { Component, Input } from '@angular/core';

@Component({
    selector: 'qbi-developer-test-task',
    templateUrl: 'task.component.html',
    styleUrls: ['task.component.scss']
})
export class QBIDeveloperTestTaskComponent {
    @Input() taskId: number | undefined;
    @Input() hasImage: boolean = false;
}