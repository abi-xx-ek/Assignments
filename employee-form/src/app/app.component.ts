import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

interface empForm {
  Name: FormControl<string | null>;
  Email: FormControl<string | null>;
  Phone: FormControl<number | null>;
  Age: FormControl<number | null>;
  skill: FormArray<FormControl<string | null>>;
}

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'employee-form';

  emp: FormGroup<empForm>;
  skills: FormArray; 
  
  ngOnInit() {
    this.emp = new FormGroup<empForm>({
      Name: new FormControl('',Validators.required),
      Email: new FormControl('',Validators.email),
      Phone: new FormControl(null,Validators.required),
      Age: new FormControl(null,Validators.required),
      skill: new FormArray([]),
    });

    this.skills = this.emp.get('skill') as FormArray; 
  }

  addSkill() {
    this.skills.push(new FormControl(''));
  }

  OnSubmitForm() {
    if (this.emp.valid) {
      console.log(this.emp.value);
    } else {
      console.log('Form is invalid');
    }
  }
  
}
