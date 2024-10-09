import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TableHtmlComponent } from '../table-html/table-html.component';
import { RefLinkComponent } from '../ref-link/ref-link.component';
import { ListColourComponent } from '../list-colour/list-colour.component';
import { ListUnorderedComponent } from '../list-unordered/list-unordered.component';
import { AlertButtonComponent } from '../alert-button/alert-button.component';
import { LeapYearComponent } from '../leap-year/leap-year.component';
import { ShoppingComponent } from '../shopping/shopping.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ShoppingComponent,RouterOutlet,TableHtmlComponent,RefLinkComponent,ListColourComponent,ListUnorderedComponent,AlertButtonComponent,LeapYearComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'Project';
}
