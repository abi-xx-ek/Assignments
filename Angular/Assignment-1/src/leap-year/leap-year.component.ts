import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-leap-year',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './leap-year.component.html',
  styleUrl: './leap-year.component.scss'
})
export class LeapYearComponent {
year:number=0;
result:string='';

leap_year(year:number) {
    if (year % 4 == 0) {
        if (year % 100 == 0) {
            if (year % 400 == 0) {
              this.result=(`${year} is a leap year`);
              return 
            } 
            else {
              this.result=(`${year} is not a leap year`);
              return 
            }
        } 
        else {
          this.result=(`${year} is a leap year`);
          return
        }
    } 
    else {
      this.result=(`${year} is not a leap year`);
      return
    }
}



}
