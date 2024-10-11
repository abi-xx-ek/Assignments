import { Component, EventEmitter, Input, Output, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { taskservice } from '../Services/taskservices';

@Component({
  selector: 'app-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './item.component.html',
  styleUrl: './item.component.scss'
})
export class ItemComponent {
  item: string = "";
  count:number=0;

  createservice:taskservice = inject(taskservice)
  countservice:taskservice=inject(taskservice)
  
  ngOnInit()
  {
    this.countservice.count$.subscribe(value=>{this.count=value});
  }

  additem() {
    if (this.item.trim()) {
      this.createservice.Oncreate(this.item)
      this.countservice.increment()
      this.item = '';
    }
  }

}
