import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RouterModule } from '@angular/router';  // הוספת RouterModule

@Component({
  selector: 'app-top-bar',
  templateUrl: './top-bar.component.html',
  styleUrls: ['./top-bar.component.scss'],
  standalone: true,
  imports: [RouterModule], // הוספת RouterModule כאן
})
export class TopBarComponent implements OnInit {
  constructor(private router: Router) {}

  ngOnInit(): void {
    this.logCurrentRoute(); // הוספת קריאה לפונקציה ב-ngOnInit
  }

  logCurrentRoute() {
    console.log(this.router.url);
  }
}
