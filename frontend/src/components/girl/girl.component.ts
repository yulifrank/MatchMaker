import { Component, Input } from '@angular/core';
import { Girl, Motza } from '../../app/models/person.model';
import { MatCardModule } from '@angular/material/card';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  standalone: true,
  imports: [CommonModule, MatCardModule, MatButtonModule, MatExpansionModule],
  selector: 'app-girl',
  templateUrl: './girl.component.html',
  styleUrls: ['./girl.component.scss']
})
export class GirlComponent {
  @Input() girl?: Girl;

  // פונקציה להחזרת המוצא בשפה העברית
  getMotzaName(motza: number | undefined): string {
    if (motza === undefined || motza === null) {
      return 'לא צויין';
    }

    // המרת הערך למחרוזת המתאימה מתוך ה-enum
    const motzaEnum = Motza[motza];
    return motzaEnum ? motzaEnum : 'לא צויין';
  }
}
