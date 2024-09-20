import { Component, Input } from '@angular/core';
import { Employee } from '../../types';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css'
})
export class EmployeeComponent {
  @Input() employee! : Employee | undefined
}
