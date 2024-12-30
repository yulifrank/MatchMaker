import { Component, OnInit } from '@angular/core';
import { PersonService } from '../../app/services/person.service';
import { Guy, Girl } from '../../app/models/person.model';

import { CommonModule } from '@angular/common';
import { GuyComponent } from '../guy/guy.component';
import { GirlComponent } from '../girl/girl.component';
import { EditPersonComponent } from "../../app/edit-person/edit-person.component";
import { MatDialog } from '@angular/material/dialog';
import { MatIcon } from '@angular/material/icon';

@Component({
  standalone: true,
  imports: [CommonModule, GuyComponent, GirlComponent,MatIcon],
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.scss'],
})
export class PersonsComponent implements OnInit {
  guys: any[] = [];
  girls: any[] = [];

  constructor(private personService: PersonService, private dialog: MatDialog) {}

  ngOnInit(): void {
    this.loadGuys();
    this.loadGirls();
  }

  private loadGuys(): void {
    this.personService.getGuys().subscribe((guys: Guy[]) => {
      this.guys = guys;
    });
  }

  private loadGirls(): void {
    this.personService.getGirls().subscribe((girls: Girl[]) => {
      this.girls = girls;
    });
  }

  onEditPerson(person: any): void {
    const dialogRef = this.dialog.open(EditPersonComponent, {
      width: '400px',
      data: person,
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.onUpdatePerson(result);
      }
    });
  }

  onUpdatePerson(updatedPerson: any): void {
    this.personService.updatePerson(updatedPerson.id, updatedPerson).subscribe(updated => {
      // עדכון פרטי האדם ברשימות המקומיות
      const index = this.guys.findIndex(guy => guy.id === updatedPerson.id);
      if (index > -1) {
        this.guys[index] = updated;
      } else {
        const girlIndex = this.girls.findIndex(girl => girl.id === updatedPerson.id);
        if (girlIndex > -1) {
          this.girls[girlIndex] = updated;
        }
      }
    });
  }

  onDeletePerson(id: number): void {
    this.personService.deletePerson(id).subscribe(() => {
      // הסרת האדם שנמחק מהמערך המתאים (לפי המגדר)
      this.guys = this.guys.filter(guy => guy.id !== id);
      this.girls = this.girls.filter(girl => girl.id !== id);
    });
  }
}
