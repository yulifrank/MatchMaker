import { Component, OnInit } from '@angular/core';
import { PersonService } from '../../app/services/person.service';
import { Guy, Girl, Motza, Person } from '../../app/models/person.model';

import { CommonModule } from '@angular/common';
import { GuyComponent } from '../guy/guy.component';
import { GirlComponent } from '../girl/girl.component';
import { EditPersonComponent } from "../../app/edit-person/edit-person.component";
import { MatDialog } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule } from '@angular/forms';

@Component({
  standalone: true,
  imports: [
    CommonModule,
    GuyComponent,
    GirlComponent,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    FormsModule
  ],
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.scss'],
})
export class PersonsComponent implements OnInit {
  guys: any[] = [];
  girls: any[] = [];
  filteredGuys: Guy[] = [];
  filteredGirls: Girl[] = [];
  motzaOptions = Object.entries(Motza).filter(([key, value]) => typeof value === 'number');


  filters: any = {
    age: '',
    name: '',
    yeshiva: '',
    openness: '',
    height: ''
  };
  opennessLevels: string[] = ['Low', 'Medium', 'High'];

  constructor(private personService: PersonService, private dialog: MatDialog) {}

  ngOnInit(): void {
    this.loadGuys();
    this.loadGirls();
  }

  private loadGuys(): void {
    this.personService.getGuys().subscribe((guys: Guy[]) => {
      this.guys = guys;
      this.filteredGuys = guys;
    });
  }

  private loadGirls(): void {
    this.personService.getGirls().subscribe((girls: Girl[]) => {
      this.girls = girls;
      this.filteredGirls = girls;
    });
  }


  resetFilters(): void {
    this.filters = {
      age: '',
      name: '',
      yeshiva: '',
      openness: '',
      height: ''
    };
    this.filteredGuys = [...this.guys];
    this.filteredGirls = [...this.girls];
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
      this.guys = this.guys.filter(guy => guy.id !== id);
      this.girls = this.girls.filter(girl => girl.id !== id);
    });
  }
  applyFilters(): void {
    this.filteredGuys = this.guys.filter(guy => this.matchesFilters(guy));
    this.filteredGirls = this.girls.filter(girl => this.matchesFilters(girl));
  }
  
  private matchesFilters(person: any): boolean {
    const matchesSearchText = this.filters.searchText ? this.isTextMatch(person, this.filters.searchText) : true;
    const matchesHeight = this.isHeightMatch(person.height);
    
    return (
      matchesSearchText &&
      (!this.filters.firstName || person.firstName.toLowerCase().includes(this.filters.firstName.toLowerCase())) &&
      (!this.filters.lastName || person.lastName.toLowerCase().includes(this.filters.lastName.toLowerCase())) &&
      (!this.filters.opennessLevel || person.opennessLevel === this.filters.opennessLevel) &&
      (!this.filters.motza || person.motza === +this.filters.motza) &&
      matchesHeight
    );
  }
  
  
  private isTextMatch(person: Person, text: string): boolean {
    const textLower = text.toLowerCase();
    
    // רשימת שדות שאותם נבדוק
    const fieldsToCheck = [
      person.firstName,
      person.lastName,
      person.birthday,
      person.opennessLevel,
      person.fatherName,
      person.motherName,
      person.height?.toString(),
      person.motza?.toString(),
      person.remark,
      person.resume,
      person.img
    ];
  
    // נבדוק אם אחד מהשדות מכיל את הטקסט החיפושי
    return fieldsToCheck.some(field => field && field.toString().toLowerCase().includes(textLower));
  }
  
  private isHeightMatch(height: number): boolean {
    const minHeight = this.filters.heightMin || 0;
    const maxHeight = this.filters.heightMax || Infinity;
    return height >= minHeight && height <= maxHeight;
  }
  
}
