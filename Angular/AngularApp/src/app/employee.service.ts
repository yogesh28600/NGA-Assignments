import { Injectable } from '@angular/core';
import { Employee } from '../types';
import { employees } from '../EmplyeeData';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  employees: Employee[];
  constructor() {
    this.employees = employees;
  }
  getEmployees() {
    return this.employees;
  }
  getEmployee(id: Number) {
    return this.employees.find((x) => x.id == id);
  }
}
