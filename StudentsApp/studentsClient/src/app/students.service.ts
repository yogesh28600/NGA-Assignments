import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from '../Types/Student';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root',
})
export class StudentsService {
  url: string = 'http://localhost:5063/api/Students';
  constructor(private http: HttpClient) {}
  getStudents(): Observable<Student[]> {
    return this.http.get<Student[]>(this.url);
  }
}
