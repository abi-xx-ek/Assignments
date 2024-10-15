import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

interface IempForm {
  firstName: FormControl<string | null>;
  lastName: FormControl<string | null>;
  email: FormControl<string | null>;
  phone: FormControl<string | null>;
  address:FormGroup<{
  addressLine1: FormControl<string | null>;
  addressLine2:FormControl<string | null>;
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
  msg:string=null;

  emp: FormGroup<IempForm>;
  
  ngOnInit() {
    this.emp = new FormGroup<IempForm>({
      firstName: new FormControl('',Validators.required),
      lastName:new FormControl(''),
      email: new FormControl('',[Validators.required,Validators.email]),
      phone: new FormControl(null,[Validators.required,Validators.pattern("[0-9]*"),Validators.maxLength(10)]),
      address:new FormGroup({
      addressLine1: new FormControl(''),
      addressLine2:new FormControl(''),
      city:new FormControl('')})
      
    });

  }

  onSubmitForm() {
    if (this.emp.valid) {
      this.data = this.emp.value;
      this.msg = 'Form submitted successfully'; 
      console.log(this.emp.value);
    } else {
      this.msg = 'The form is invalid'; 
      console.log('The Form is invalid');
    }
  }
  
}
