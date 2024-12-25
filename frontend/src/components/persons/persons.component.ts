import { Component, OnInit } from '@angular/core';
import { PersonService } from '../../app/services/person.service';
import { Guy, Girl } from '../../app/models/person.model';

import { CommonModule } from '@angular/common';
import { GuyComponent } from '../guy/guy.component';
import { GirlComponent } from '../girl/girl.component';

@Component({
  standalone: true,
  imports: [CommonModule, GuyComponent, GirlComponent],
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.scss'],
})
export class PersonsComponent implements OnInit {
  guys: Guy[] = [];
  girls: Girl[] = [];

  constructor(private personService: PersonService) {}

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
}
