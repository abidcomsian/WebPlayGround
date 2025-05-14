import { Routes } from '@angular/router';
import { AppComponent } from './app.component';

export const appRoutes: Routes = [
  { path: 'register', component: AppComponent },
  { path: '', redirectTo: 'register', pathMatch: 'full' }
];

export const routes: Routes = [];
