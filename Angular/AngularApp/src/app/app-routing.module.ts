import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeelistComponent } from './employeelist/employeelist.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';

const routes: Routes = [
  { path: 'employee/create', component: AddEmployeeComponent },
  { path: 'employee/:emp_id', component: EmployeeComponent },
  { path: 'employees', component: EmployeelistComponent },
  { path: '', redirectTo: '/employees', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
