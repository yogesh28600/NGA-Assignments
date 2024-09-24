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
      fName: ['', Validators.required],
      mName: [''],
      lName: ['', Validators.required],
      Age: [0, Validators.max(100)],
      Gender: [''],
      Country: ['', Validators.required],
      isExperienced: [false],
      Experience: [0],
      email: ['', [Validators.required, Validators.email]],
    });
  }
  saveEmployee(employee: FormGroup) {
    if (employee.valid) {
      this._empService.addEmployee(employee.value).subscribe();
      this._router.navigate(['employees']);
    }
  }
}
