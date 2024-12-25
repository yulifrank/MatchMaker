import { Component, Input } from '@angular/core';
import { Guy, Motza } from '../../app/models/person.model';
import { MatCardModule } from '@angular/material/card';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatExpansionModule } from '@angular/material/expansion';

@Component({
  standalone: true,
  imports: [CommonModule, MatCardModule, MatButtonModule, MatExpansionModule],
  selector: 'app-guy',
  templateUrl: './guy.component.html',
  styleUrls: ['./guy.component.scss']
})
export class GuyComponent {
  @Input() guy?: Guy;
  // פונקציה להחזרת המוצא בשפה העברית
getMotzaName(motza: Motza | undefined): string {
  if (!motza) return 'לא צויין';
  return motza;
}

}
