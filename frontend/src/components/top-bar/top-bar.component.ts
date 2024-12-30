import { Component, OnInit } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { MatToolbar } from '@angular/material/toolbar';
import { Router } from '@angular/router';  // הוספת Router
import { RouterModule } from '@angular/router';  // הוספת RouterModule

@Component({
  selector: 'app-top-bar',
  standalone: true, // רכיב עצמאי
  templateUrl: './top-bar.component.html',
  styleUrls: ['./top-bar.component.scss'],
  imports: [RouterModule,MatIcon,MatToolbar], // מייבא את RouterModule כאן
})
export class TopBarComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit(): void {
    this.logCurrentRoute(); // קריאה לפונקציה
  }

  logCurrentRoute() {
    console.log(this.router.url); // לוג של ה-URL הנוכחי
  }
}
