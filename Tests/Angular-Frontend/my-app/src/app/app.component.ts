import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms'; // Required for ngModel
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule], // ✅ Include FormsModule
  template: `
    <h2>Register</h2>
    <form (ngSubmit)="register()" #regForm="ngForm">
      <label>Email:</label>
      <input type="email" name="email" [(ngModel)]="user.email" required /><br />

      <label>Password:</label>
      <input type="password" name="password" [(ngModel)]="user.password" required /><br />

      <button type="submit">Register</button>
    </form>
  `
})
export class AppComponent {
  user = { email: '', password: '' };

  constructor(private http: HttpClient) { }

  register() {
    this.http.post('https://localhost:5001/api/auth/register', this.user).subscribe({
      next: () => alert('Registration successful!'),
      error: () => alert('Registration failed.')
    });
  }
}
