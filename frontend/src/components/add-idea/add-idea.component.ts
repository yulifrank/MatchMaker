import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Guy, Girl } from '../../app/models/person.model';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatOption, MatOptionModule } from '@angular/material/core';
import { MatSelect } from '@angular/material/select';


@Component({
  standalone:true,
  imports:[FormsModule,ReactiveFormsModule,MatFormFieldModule,MatSelect,MatOption],
  selector: 'app-add-idea',
  templateUrl: './add-idea.component.html',
  styleUrls: ['./add-idea.component.scss'],
})
export class AddIdeaComponent {
  @Input() guys: Guy[] = [];
  @Input() girls: Girl[] = [];
  @Output() ideaAdded = new EventEmitter<{ guy: Guy; girl: Girl }>();

  selectedGuy?: Guy;
  selectedGirl?: Girl;

  addIdea() {
    if (this.selectedGuy && this.selectedGirl) {
      this.ideaAdded.emit({ guy: this.selectedGuy, girl: this.selectedGirl });
    }
  }
}
