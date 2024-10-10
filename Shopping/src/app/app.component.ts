import { Component } from '@angular/core';
import { ItemComponent } from './item/item.component';
import { ListComponent } from './list/list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ItemComponent,ListComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  items: string[] = [];
  count: number = 0;

  onItemsChange(updatedItems: string[]) {
    this.items = updatedItems;
  }

  onCountChange(updatedCount: number) {
    this.count = updatedCount;
  }
}
