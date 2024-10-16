import { Component } from '@angular/core';
import { StudentsService } from '../students.service';
import { Student } from '../../Types/Student';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-students-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './students-list.component.html',
  styleUrl: './students-list.component.css',
})
export class StudentsListComponent {
  Students: Student[] = [];
  constructor(private services: StudentsService) {
    this.services.getStudents().subscribe((data) => {
      this.Students = data;
    });
  }
}
