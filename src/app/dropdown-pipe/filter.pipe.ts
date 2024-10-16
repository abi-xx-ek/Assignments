import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
  standalone: true
})
export class FilterPipe implements PipeTransform {

  transform(value: any):any {
    for(let item of value){
      if (item.isActive===true){
        return value;
    }
    }
    
  }

}
