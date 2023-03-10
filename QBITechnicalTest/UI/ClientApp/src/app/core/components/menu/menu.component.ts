import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { QBIDeveloperTestMenuService } from '../../services/menu.service';
import {MenuItem} from "primeng/api";

@Component({
    selector: 'qbi-developer-test-menu',
    templateUrl: 'menu.component.html',
    styleUrls: ['menu.component.scss']
})
export class QBIDeveloperTestMenuComponent implements OnInit {
    menus$: Observable<MenuItem[]> | undefined;

    constructor(
        private readonly QBIDeveloperTestMenuService: QBIDeveloperTestMenuService
    ) { }

    async ngOnInit() {
      this.menus$ = this.QBIDeveloperTestMenuService.getMenus();
    }
}
