import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-shopping',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './shopping.component.html',
  styleUrls: ['./shopping.component.scss'] 
})
export class ShoppingComponent {
  item: string = '';
  items: string[] = []; 

  additem() {
    if (this.item.trim()) {
      this.items.push(this.item); 
      this.item=''
    }
  }

  deleteItem(index: number) {
    this.items.splice(index, 1); 
  }
}
