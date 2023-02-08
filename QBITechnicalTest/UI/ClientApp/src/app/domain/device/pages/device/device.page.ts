import {Component, OnInit} from '@angular/core';
import {from, Observable, tap} from 'rxjs';
import {DeviceService} from "../../services/device.service";
import {Product} from "../../../../core/models/product.model";

@Component({
  templateUrl: 'device.page.html',
  styleUrls: ['device.page.scss']
})
export class DevicePage implements OnInit {
  loading: boolean = false;
  products: Product[] = [];
  tasks$: Observable<Task[]> | undefined;

  constructor(
    private readonly deviceService: DeviceService
  ) {
  }

  ngOnInit() {
    from(this.deviceService.getProductsSmall()).pipe(
      tap((_) => {
        this.loading = true;
      })
    ).subscribe(data => {
      // this.loading = false;
      this.products = data;
    });
    // this.tasks$ = this.QBIDeveloperTestHomeService.getTasks();
  }
}
