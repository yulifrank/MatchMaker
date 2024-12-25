
import { Component, OnInit } from '@angular/core';
import { IdeaService } from '../../app/services/idea.service';
import { CommonModule } from '@angular/common';
import { Idea } from '../../app/models/idea.model';

@Component({
  selector: 'app-ideas',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './ideas.component.html',
  styleUrls: ['./ideas.component.scss'] // Corrected from styleUrl to styleUrls
})
export class IdeasComponent implements OnInit {
  ideas: Idea[] = [];

  constructor(private ideaService: IdeaService) {}

  ngOnInit(): void {
    this.ideaService.getIdeas().subscribe(data => {
      this.ideas = data;
    });
  }

  deleteIdea(id: number): void {
    this.ideaService.deleteIdea(id).subscribe(() => {
      this.ideas = this.ideas.filter(idea => idea.id !== id);
    });
  }
}
