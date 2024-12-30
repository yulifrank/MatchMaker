import { Component, EventEmitter, Inject, Input, Output } from '@angular/core';
import { Person } from '../models/person.model';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatExpansionModule } from '@angular/material/expansion';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-edit-person',
  imports: [    
    MatCardModule,
    MatExpansionModule,
    MatButtonModule,
    FormsModule, CommonModule,],
  templateUrl: './edit-person.component.html',
  styleUrl: './edit-person.component.scss'
})
export class EditPersonComponent {
  constructor(
    public dialogRef: MatDialogRef<EditPersonComponent>,  // כדי לסגור את הדיאלוג
    @Inject(MAT_DIALOG_DATA) public person: Person  // קבלת הנתונים שהועברו
  ) {}

  save() {
    this.dialogRef.close(this.person);  // סגירת הדיאלוג והחזרת הערכים המעודכנים
  }

  cancel() {
    this.dialogRef.close();  // סגירת הדיאלוג ללא עדכון
  }
}