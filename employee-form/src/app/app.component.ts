import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

interface empForm {
  FirstName: FormControl<string | null>;
  LastName: FormControl<string | null>;
  Email: FormControl<string | null>;
  Phone: FormControl<string | null>;
  address:FormGroup<{
  Addressline1: FormControl<string | null>;
  Addressline2:FormControl<string | null>;
  city:FormControl<string|null>}>;
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
  data:any;
  emp: FormGroup<empForm>;
  
  ngOnInit() {
    this.emp = new FormGroup<empForm>({
      FirstName: new FormControl('',Validators.required),
      LastName:new FormControl(''),
      Email: new FormControl('',[Validators.required,Validators.email]),
      Phone: new FormControl(null,[Validators.required,Validators.pattern("[0-9]*"),Validators.maxLength(10)]),
      address:new FormGroup({
      Addressline1: new FormControl(''),
      Addressline2:new FormControl(''),
      city:new FormControl('')})
      
    });

  }

  OnSubmitForm() {
    if (this.emp.valid) {
      this.data=this.emp.value;
      console.log(this.emp.value);
    } 
    else {
      console.log('The Form is invalid');
    }
  }
  
}
