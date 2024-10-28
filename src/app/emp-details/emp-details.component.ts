import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

interface IempForm {
  firstName: FormControl<string | null>;
  lastName: FormControl<string | null>;}

@Component({
  selector: 'app-emp-details',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule],
  templateUrl: './emp-details.component.html',
  styleUrl: './emp-details.component.scss'
})
export class EmpDetailsComponent implements OnInit
{
  emp: FormGroup<IempForm>;
  data:any;

  ngOnInit() {
    this.emp=new FormGroup<IempForm>({
      firstName:new FormControl('',Validators.required),
      lastName:new FormControl('') 
    });
  }
  onClick(){
    if (this.emp.valid) {
      this.data = this.emp.value;
  }
}
}
