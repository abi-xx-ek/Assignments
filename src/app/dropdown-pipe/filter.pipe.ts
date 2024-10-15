import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter',
  standalone: true
})
export class FilterPipe implements PipeTransform {

  transform(value: unknown, isActive : boolean): any {
    if (isActive==true){
      return value;
    }
  
  }

}
