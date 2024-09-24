import { Component, Input } from '@angular/core';
import { Employee } from '../../types';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from '../employee.service';
import { AbstractControl, NgForm } from '@angular/forms';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css',
})
export class EmployeeComponent {
  employee: Employee | undefined;
  constructor(
    private router: ActivatedRoute,
    private employees: EmployeeService,
    private _navRouter: Router
  ) {
    var id: Number = this.router.snapshot.params['emp_id'];
    this.employees.getEmployee(id).subscribe((data) => {
      this.employee = data;
    });
  }
  saveEmployee(employeeForm: NgForm) {
    if (employeeForm.valid) {
      this.employees.updateEmployee(employeeForm.value).subscribe((data) => {
        console.log(data);
      });
      this._navRouter.navigate(['employees']);
    }
  }
}
