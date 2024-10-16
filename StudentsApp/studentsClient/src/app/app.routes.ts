import { Routes } from '@angular/router';
import { StudentsListComponent } from './students-list/students-list.component';
import { HomeComponent } from './home/home.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { NotfoundComponent } from './notfound/notfound.component';

export const routes: Routes = [
  { path: 'students', component: StudentsListComponent },
  { path: 'home', component: HomeComponent },
  { path: 'about-us', component: AboutUsComponent },
  { path: 'contact-us', component: ContactUsComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: NotfoundComponent },
];
