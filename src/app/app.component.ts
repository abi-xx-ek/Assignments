import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EmpDetailsComponent } from './emp-details/emp-details.component';
import { DropdownComponent } from './dropdown/dropdown.component';
import { DropdownPipeComponent } from './dropdown-pipe/dropdown-pipe.component';
import { FormComponent } from './form/form.component';
import { HoverDirective } from './hover.directive';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,EmpDetailsComponent,DropdownComponent,DropdownPipeComponent,FormComponent,HoverDirective],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'angular-pipe';
}
