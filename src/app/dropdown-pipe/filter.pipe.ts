import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
  standalone: true
})
export class FilterPipe implements PipeTransform {

  transform(value: Array<any>,isActive:boolean):any {
   return value.filter((x:any)=>x.isActive===isActive)
    }
    
  }


