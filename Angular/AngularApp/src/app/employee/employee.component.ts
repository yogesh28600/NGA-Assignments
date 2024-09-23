import { Component, Input } from '@angular/core';
import { Employee } from '../../types';
import { ActivatedRoute } from '@angular/router';
import { EmployeeService } from '../employee.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css',
})
export class EmployeeComponent {
  employee: Employee | undefined;
  constructor(
    private router: ActivatedRoute,
    private employees: EmployeeService
  ) {
    var id: Number = this.router.snapshot.params['emp_id'];
    this.employee = this.employees.getEmployee(id);
  }
  saveEmployee(employeeForm: NgForm) {
    console.log(employeeForm.value);
  }
}
