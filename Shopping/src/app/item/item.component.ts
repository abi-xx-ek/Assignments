import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './item.component.html',
  styleUrl: './item.component.scss'
})
export class ItemComponent {
  item: string = '';
  @Input() items: string[] = [];
  @Output() itemsChange = new EventEmitter<string[]>();

  @Input() count:number=0;
  @Output() countChange = new EventEmitter<number>();


  additem() {
    if (this.item.trim()) {
      this.items.push(this.item);
      this.count++;
      this.itemsChange.emit(this.items);
      this.countChange.emit(this.count)
      this.item = '';
    }
  }

}
