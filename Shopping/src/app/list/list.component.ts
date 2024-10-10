import { CommonModule } from '@angular/common';
import { Component, Input, Output, EventEmitter } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-list',
  imports: [FormsModule,CommonModule],

  standalone: true,
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {
 
  @Input() items: string[] = [];
  @Output() itemsChange = new EventEmitter<string[]>();

  @Input() count : number =0;
  @Output() countChange = new EventEmitter<number>();

  deleteItem(index: number) {
    this.items.splice(index, 1);
    this.count--;
    this.itemsChange.emit(this.items);
    this.countChange.emit(this.count);
  }
}
