import { Component } from '@angular/core';
import { Employee } from '../../types';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  NgForm,
  Validators,
} from '@angular/forms';
import { EmployeeService } from '../employee.service';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css',
})
export class AddEmployeeComponent {
  employeeForm: FormGroup;
  constructor(
    private _empService: EmployeeService,
    private _router: Router,
    private _form: FormBuilder
  ) {
    this.employeeForm = this._form.group({
      id: ['', Validators.required],
      fName: [''],
      mName: [''],
      lName: [''],
      Age: [0],
      Gender: [''],
      isExperienced: [false],
      Experience: [0],
      email: [''],
    });
  }
  saveEmployee(employee: FormGroup) {
    if (employee.valid) {
      this._empService.addEmployee(employee.value).subscribe();
      this._router.navigate(['employees']);
    }
  }
}
