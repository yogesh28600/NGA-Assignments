import { Component } from '@angular/core';
import { Employee } from '../../types';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css',
})
export class AddEmployeeComponent {
  employee: Employee = {
    id: 0,
    fName: '',
    mName: '',
    lName: '',
    Age: 0,
    Gender: '',
    Country: '',
    isExperienced: false,
    Experience: 0,
    email: '',
  };
  saveEmployee(employee: NgForm) {}
}
