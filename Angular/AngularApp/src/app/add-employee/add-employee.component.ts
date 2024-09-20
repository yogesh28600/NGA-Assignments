import { Component } from '@angular/core';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css'
})
export class AddEmployeeComponent {
  fName:string = ""
  mName:string = ""
  lName:string = ""
  gender:string = ""
  age!:Number
  country:string = ""
}
