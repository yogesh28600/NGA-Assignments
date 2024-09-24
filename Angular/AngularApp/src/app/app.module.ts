import { NgModule } from '@angular/core';
import {
  BrowserModule,
  provideClientHydration,
} from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeelistComponent } from './employeelist/employeelist.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { EmailValidation } from '../validators/email-validation';
import { provideHttpClient } from '@angular/common/http';
import { EmployeeService } from './employee.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    EmployeeComponent,
    EmployeelistComponent,
    AddEmployeeComponent,
    PageNotFoundComponent,
    EmailValidation,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  providers: [provideClientHydration(), provideHttpClient(), EmployeeService],
  bootstrap: [AppComponent],
})
export class AppModule {}
