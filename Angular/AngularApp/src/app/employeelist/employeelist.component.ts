import { Component } from '@angular/core';
import { Employee } from '../../types';
import { EmployeeData } from '../../EmplyeeData';

@Component({
  selector: 'app-employeelist',
  templateUrl: './employeelist.component.html',
  styleUrl: './employeelist.component.css'
})
export class EmployeelistComponent {
  employeeList:Employee[] = EmployeeData
  showEmployee:Boolean = false
  employee:Employee | undefined
  viewEmployee(id:Number){
    this.employee = this.employeeList.find(emp=>emp.id == id)
    this.showEmployee = !this.showEmployee
  }
}
