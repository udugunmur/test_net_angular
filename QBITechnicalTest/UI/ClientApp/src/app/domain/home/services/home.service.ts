import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { useMock } from '../../../core/decorators/use-mock.decorator';
import { QBIDeveloperTestAPIBase } from '../../../core/services/api.base';
import { Task } from '../models/task.model';

@Injectable({
    providedIn: 'root'
})
export class QBIDeveloperTestHomeService extends QBIDeveloperTestAPIBase {
    protected controller: string = 'Home';

    constructor(
        protected override readonly httpClient: HttpClient
    ) {
        super(httpClient);
    }

    @useMock('tasks')
    getTasks(): Observable<Task[]> {
        return this.get<Task[]>('');
    }
}