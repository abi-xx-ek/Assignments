import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FilterPipe } from './filter.pipe';

@Component({
  selector: 'app-dropdown-pipe',
  standalone: true,
  imports: [CommonModule,FilterPipe],
  templateUrl: './dropdown-pipe.component.html',
  styleUrl: './dropdown-pipe.component.scss'
})
export class DropdownPipeComponent {
  data:Array<object>;
  
  constructor() {
    this.data = [
      { name: "Hilite", isActive: true },
      { name: "Lulu", isActive: true },
      { name: "Cordova School", isActive: true },
      { name: "Azure Heights Apartments", isActive: true },
      { name: "Greenfield Mall", isActive: true },
      { name: "Pinnacle Corporate Towers", isActive: true },
      { name: "Sunshine Valley Resort", isActive: true },
      { name: "Everest Office Park", isActive: false },
      { name: "Maplewood Villas", isActive: false },
      { name: "Sterling Shopping Complex", isActive: false }
    ]
  }

}
