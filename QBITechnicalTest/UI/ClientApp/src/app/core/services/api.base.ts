import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

export abstract class QBIDeveloperTestAPIBase {
    protected abstract controller: string;

    constructor(
        protected readonly httpClient: HttpClient
    ) { }

    protected get<TType>(methodName: string, params: any = {}): Observable<TType> {
        return this.httpClient.get<TType>(`${environment.apiUrl}/${this.controller}/${methodName}`, {
            observe: 'body',
            params: params
        })
    }

    protected post<TType>(methodName: string, data: any = null, params: any = {}): Observable<TType> {
        return this.httpClient.post<TType>(`${environment.apiUrl}/${this.controller}/${methodName}`, data, {
            observe: 'body',
            params: params
        });
    }

    protected put<TType>(methodName: string, data: any = null, params: any = {}): Observable<TType> {
        return this.httpClient.put<TType>(`${environment.apiUrl}/${this.controller}/${methodName}`, data, {
            observe: 'body',
            params: params
        });
    }

    protected delete<TType>(methodName: string, params: any = {}): Observable<TType> {
        return this.httpClient.delete<TType>(`${environment.apiUrl}/${this.controller}/${methodName}`, {
            observe: 'body',
            params: params
        });
    }
}