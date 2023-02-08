import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {QBIDeveloperTestAPIBase} from "../../../core/services/api.base";
import {Observable} from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class DeviceService extends QBIDeveloperTestAPIBase {
  protected controller: string = "Device";

  constructor(protected override readonly httpClient: HttpClient)  {
    super(httpClient);
  }

  getDevice(): Observable<any> {
    return this.get<any>('');
  }
}
