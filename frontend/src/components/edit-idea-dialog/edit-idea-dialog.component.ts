import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatFormField, MatLabel } from '@angular/material/form-field';

@Component({
  standalone: true,
  selector: 'app-edit-idea-dialog',
  imports: [FormsModule,MatFormField,MatLabel],
  templateUrl: './edit-idea-dialog.component.html',
  styleUrls: ['./edit-idea-dialog.component.scss']
})
export class EditIdeaDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<EditIdeaDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  onNoClick(): void {
    this.dialogRef.close();
  }saveStatus(): void {
    this.dialogRef.close({
      statusDescription: this.data.statusDescription,
      girlId: this.data.girlId,  // שליחה חזרה של girlId
      guyId: this.data.guyId  // שליחה חזרה של guyId
    });
  }
  
  
}
