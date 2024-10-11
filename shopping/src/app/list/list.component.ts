import { CommonModule } from '@angular/common';
import { Component, Input, Output, EventEmitter, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { taskservice } from '../Services/taskservices';

@Component({
  selector: 'app-list',
  imports: [FormsModule,CommonModule],

  standalone: true,
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit
{
  count:number=0;
  items:string[]=[];
  createservice:taskservice = inject(taskservice)
  countservice:taskservice=inject(taskservice)


  ngOnInit(){
    this.createservice.createemitter.subscribe((value)=>{
    this.items.push(value)})
    
    this.countservice.count$.subscribe(value=>{
      this.count=value})
    }
 


  deleteItem(index: number) {
    this.items.splice(index, 1);
    this.countservice.decrement()
   }
}
