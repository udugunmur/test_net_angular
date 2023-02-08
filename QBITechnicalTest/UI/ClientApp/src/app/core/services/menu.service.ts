import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { useMock } from '../decorators/use-mock.decorator';
import { QBIDeveloperTestAPIBase } from './api.base';
import {MenuItem} from "primeng/api";

@Injectable({
    providedIn: 'root'
})
export class QBIDeveloperTestMenuService extends QBIDeveloperTestAPIBase {
    protected controller: string = 'Menu';

    constructor(
        protected override readonly httpClient: HttpClient
    ) {
        super(httpClient);
    }

    @useMock('menu')
    getMenus(): Observable<MenuItem[]> {
        return this.get<MenuItem[]>('');
    }
}
