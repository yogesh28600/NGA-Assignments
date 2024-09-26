import { Injectable } from '@angular/core';
import { Employee } from '../types';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  url: string = 'http://localhost:3000/employees/';
  constructor(private _httpClient: HttpClient) {}
  getEmployees(): Observable<Employee[]> {
    return this._httpClient.get<Employee[]>(this.url);
  }
  getEmployee(id: Number): Observable<Employee> {
    const url: string = this.url + id;
    return this._httpClient.get<Employee>(url);
  }
  addEmployee(emp: Employee): Observable<Employee> {
    return this._httpClient.post<Employee>(this.url, emp);
  }
  updateEmployee(emp: Employee): Observable<Employee> {
    const url: string = this.url + emp.id;
    return this._httpClient.put<Employee>(url, emp);
  }
}
