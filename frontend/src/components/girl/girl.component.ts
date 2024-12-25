import { Component, Input } from '@angular/core';
import { Girl, Motza } from '../../app/models/person.model';
import { MatCardModule } from '@angular/material/card';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
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
getMotzaName(motza: Motza | undefined): string {
  if (!motza) return 'לא צויין';
  return motza;
}

}
