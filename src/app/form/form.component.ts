import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormControl, ReactiveFormsModule, FormGroup, Validators } from '@angular/forms';
import { FilterPipe } from '../dropdown-pipe/filter.pipe';
import { NgSelectModule } from '@ng-select/ng-select';
import { HoverDirective } from '../hover.directive';
import { EmailDirective } from '../email.directive';

interface IempForm {
  firstName: FormControl<string | null>;
  lastName: FormControl<string | null>;
  select:FormControl<any|null>;
  email:FormControl<string|null>}


@Component({
  selector: 'app-form',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule,FilterPipe,NgSelectModule,HoverDirective,EmailDirective],
  templateUrl: './form.component.html',
  styleUrl: './form.component.scss'
})
export class FormComponent implements OnInit
{
  emp: FormGroup<IempForm>;
  data:any;
  projects=[
    { name: "Hilite",isActive: true },
    { name: "Lulu", isActive: true },
    { name: "Cordova School", isActive: true },
    { name: "Azure Heights Apartments", isActive: true },
    { name: "Greenfield Mall", isActive: true },
    { name: "Pinnacle Corporate Towers", isActive: true },
    { name: "Sunshine Valley Resort", isActive: true },
    { name: "Everest Office Park", isActive: false },
    { name: "Maplewood Villas", isActive: false },
    { name: "Sterling Shopping Complex", isActive: false }
  ]

  ngOnInit() {
    this.emp=new FormGroup<IempForm>({
      firstName:new FormControl('',Validators.required),
      lastName:new FormControl(''),
      select:new FormControl(null),
      email:new FormControl('')
    });
  }
  onClick(){
    if (this.emp.valid) {
      this.data = this.emp.value;
  }
}
}