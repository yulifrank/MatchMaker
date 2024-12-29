import { Component, OnInit } from '@angular/core';
import { IdeaService } from '../../app/services/idea.service';
import { PersonService } from '../../app/services/person.service';
import { Guy, Girl } from '../../app/models/person.model';
import { Idea, IdeaPostModel } from '../../app/models/idea.model';
import { MatDialog } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { EditIdeaDialogComponent } from '../edit-idea-dialog/edit-idea-dialog.component';
import { MatCardActions } from '@angular/material/card';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-ideas',
  standalone: true,
  imports: [
    CommonModule,
    MatButtonModule,
    MatExpansionModule,
    MatInputModule,
    MatSelectModule,
    MatCardActions,
    FormsModule
  ],
  templateUrl: './ideas.component.html',
  styleUrls: ['./ideas.component.scss']
})
export class IdeasComponent implements OnInit {
  ideas: any[] = [];
  guys: Guy[] = [];
  girls: Girl[] = [];

  selectedGuy?: Guy;
  selectedGirl?: Girl;

  constructor(
    private ideaService: IdeaService,
    private personService: PersonService,
    private dialog: MatDialog
  ) {}

  ngOnInit(): void {
    this.loadIdeas();
    this.loadPeople();
  }

  private loadIdeas(): void {
    this.ideaService.getIdeas().subscribe(data => {
      this.ideas = data;
    });
  }

  private loadPeople(): void {
    this.personService.getGuys().subscribe(guys => (this.guys = guys));
    this.personService.getGirls().subscribe(girls => (this.girls = girls));
  }

  addIdea(): void {
    if (this.selectedGuy && this.selectedGirl) {
      const newIdea: IdeaPostModel = {
        statusDescription: 'חדש',
        guyId: this.selectedGuy.id,  // שומרים רק את ה-ID של ה-`Guy`
        girlId: this.selectedGirl.id, // שומרים רק את ה-ID של ה-`Girl`
      };

      this.ideaService.addIdea(newIdea).subscribe(() => {
         this.ideas.push(newIdea);
        this.resetSelection();
      });
    }
  }

  editIdea(idea: Idea): void {
    const dialogRef = this.dialog.open(EditIdeaDialogComponent, {
      width: '400px',
      data: {
        statusDescription: idea.statusDescription,
        girlId: idea.girlId,
        guyId: idea.guyId
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.updateIdeaStatus(idea.id, result.statusDescription, result.girlId, result.guyId);
      }
    });
  }

  updateIdeaStatus(id: number, status: string, girlId: number, guyId: number): void {
    const updatedIdea = { id, statusDescription: status, girlId, guyId };
    this.ideaService.updateIdea(id, updatedIdea).subscribe(() => {
      const index = this.ideas.findIndex(idea => idea.id === id);
      if (index !== -1) {
        this.ideas[index] = { ...this.ideas[index], statusDescription: status, girlId, guyId };
      }
    });
  }

  deleteIdea(id: number): void {
    this.ideaService.deleteIdea(id).subscribe(() => {
      this.ideas = this.ideas.filter(idea => idea.id !== id);
    });
  }

  private resetSelection(): void {
    this.selectedGuy = undefined;
    this.selectedGirl = undefined;
  }
}
