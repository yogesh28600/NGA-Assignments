import { Component } from '@angular/core';
import { Employee } from '../../types';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employeelist',
  templateUrl: './employeelist.component.html',
  styleUrl: './employeelist.component.css',
})
export class EmployeelistComponent {
  employeeList: Employee[];
  constructor(private emp_service: EmployeeService) {
    this.employeeList = this.emp_service.getEmployees();
  }
}
