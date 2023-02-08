import {Component, OnInit} from '@angular/core';
import {Observable} from 'rxjs';
import {DeviceService} from "../../services/device.service";
import {DeviceTypeViewModel} from "../../../../core/models/device-type-view-model.model";

@Component({
  templateUrl: 'device.page.html',
  styleUrls: ['device.page.scss']
})
export class DevicePage implements OnInit {
  tasks$: Observable<DeviceTypeViewModel[]> | undefined;

  constructor(
    private readonly deviceService: DeviceService
  ) {
  }

  ngOnInit() {
    this.tasks$ = this.deviceService.getDevice();
  }
}
