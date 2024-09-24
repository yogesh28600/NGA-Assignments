import { Injectable } from '@angular/core';
import { Employee } from '../types';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  constructor(private _httpClient: HttpClient) {}
  getEmployees(): Observable<Employee[]> {
    const url: string = 'http://localhost:3000/employees';
    return this._httpClient.get<Employee[]>(url);
  }
  getEmployee(id: Number): Observable<Employee> {
    const url: string = 'http://localhost:3000/employees/' + id;
    return this._httpClient.get<Employee>(url);
  }
  addEmployee(emp: Employee): Observable<Employee> {
    const url: string = 'http://localhost:3000/employees';
    return this._httpClient.post<Employee>(url, emp);
  }
  updateEmployee(emp: Employee): Observable<Employee> {
    const url: string = 'http://localhost:3000/employees/' + emp.id;
    return this._httpClient.put<Employee>(url, emp);
  }
}
