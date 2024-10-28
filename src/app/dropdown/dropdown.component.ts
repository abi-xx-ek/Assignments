import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FilterPipe } from '../dropdown-pipe/filter.pipe';

@Component({
  selector: 'app-dropdown',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './dropdown.component.html',
  styleUrl: './dropdown.component.scss'
})
export class DropdownComponent {

  data:Array<any>;

  constructor() {
    this.data = [
      { "name": "Hilite", "isActive": true },
      { "name": "Lulu", "isActive": true },
      { "name": "Cordova School", "isActive": true },
      { "name": "Azure Heights Apartments", "isActive": true },
      { "name": "Greenfield Mall", "isActive": true },
      { "name": "Pinnacle Corporate Towers", "isActive": true },
      { "name": "Sunshine Valley Resort", "isActive": true },
      { "name": "Everest Office Park", "isActive": false },
      { "name": "Maplewood Villas", "isActive": false },
      { "name": "Sterling Shopping Complex", "isActive": false }
    ]
  }
}
