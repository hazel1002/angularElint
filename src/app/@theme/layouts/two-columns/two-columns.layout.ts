import { Component } from '@angular/core';
import { FooterComponent } from '../../components/footer/footer.component';
import { HeaderComponent } from '../../components/header/header.component';
import { NbLayoutModule, NbSidebarModule } from '@nebular/theme';

@Component({
  selector: 'ngx-two-columns-layout',
  styleUrls: ['./two-columns.layout.scss'],
  template: `
    <nb-layout windowMode>
      <nb-layout-header fixed>
        <ngx-header></ngx-header>
      </nb-layout-header>

      <nb-sidebar class="menu-sidebar" tag="menu-sidebar" responsive>
        <ng-content select="nb-menu"></ng-content>
      </nb-sidebar>

      <nb-layout-column class="small"> </nb-layout-column>

      <nb-layout-column>
        <ng-content select="router-outlet"></ng-content>
      </nb-layout-column>

      <nb-layout-footer fixed>
        <ngx-footer></ngx-footer>
      </nb-layout-footer>
    </nb-layout>
  `,
  standalone: true,
  imports: [NbLayoutModule, HeaderComponent, NbSidebarModule, FooterComponent],
})
export class TwoColumnsLayoutComponent {}
