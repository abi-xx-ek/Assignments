import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
  standalone: true
})
export class FilterPipe implements PipeTransform {

  transform(value: any):any {
    if (value.isActive===true){
      return value.name;
    }
    
  }

}
