import { Routes } from '@angular/router';
import { TableHtmlComponent } from '../table-html/table-html.component';
import { RefLinkComponent } from '../ref-link/ref-link.component';
import { ListColourComponent } from '../list-colour/list-colour.component';
import { ListUnorderedComponent } from '../list-unordered/list-unordered.component';
import { LeapYearComponent } from '../leap-year/leap-year.component';
import { ShoppingComponent } from '../shopping/shopping.component';
import { AlertButtonComponent } from '../alert-button/alert-button.component';
export const routes: Routes = [
  { path: 'table', component: TableHtmlComponent },
  { path: 'ref-link', component: RefLinkComponent },
  { path: 'list-colour', component: ListColourComponent },
  { path: 'list-unordered', component: ListUnorderedComponent },
  { path: 'leap-year-checker', component: LeapYearComponent },
  { path: 'shopping', component: ShoppingComponent },
  { path: 'alert', component: AlertButtonComponent }
  
];
