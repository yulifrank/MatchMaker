import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { PersonService } from '../../app/services/person.service'; // עדכון הנתיב בהתאם למיקום הסרוויס
import { Girl, Guy, Motza } from '../../app/models/person.model';

@Component({
  standalone: true,
  imports: [FormsModule, CommonModule],
  selector: 'app-new-person',
  templateUrl: './new-person.component.html',
  styleUrls: ['./new-person.component.scss']
})
export class NewPersonComponent {
  personType: 'Guy' | 'Girl' = 'Guy'; // ברירת מחדל לבחירת סוג האדם

  Motza = Motza; // הוספת משתנה זה כדי להנגיש את enum בתבנית

  guy: Guy = {
    id:0,
    firstName: '',
    lastName: '',
    birthday: '',
    fatherName: '',
    motherName: '',
    height: 0,
    motza: Motza.Ashcenaz,
    vaad: 0,
    img: '',
    resume: '',
    opennessLevel: 0,
    remark: ''
  };

  girl: Girl = {
    id:0,
    firstName: '',
    lastName: '',
    birthday: '',
    fatherName: '',
    motherName: '',
    height: 0,
    motza: Motza.Ashcenaz,
    subject: '',
    yearbook: 0,
    img: '',
    resume: '',
    opennessLevel: 0,
    remark: ''
  };

  constructor(private personService: PersonService) {}

  onImageChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      if (this.personType === 'Guy') {
        this.guy.img = file.name; // שמירת שם הקובץ בלבד
      } else {
        this.girl.img = file.name; // שמירת שם הקובץ בלבד
      }
    }
  }
  
  onResumeChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      if (this.personType === 'Guy') {
        this.guy.resume = file.name; // שמירת שם הקובץ בלבד
      } else {
        this.girl.resume = file.name; // שמירת שם הקובץ בלבד
      }
    }
  }
  
  onSubmit() {
    if (this.personType === 'Girl') {
      const girl: Girl = {
        ...this.girl,
        birthday: new Date(this.girl.birthday).toISOString().split('T')[0] // המרת התאריך לפורמט ISO
      };
      this.personService.addGirl(girl).subscribe(
        (response: Girl) => console.log('Success:', response),
        (error: any) => console.error('Error:', error)
      );
    } else if (this.personType === 'Guy') {
      const guy: Guy = {
        ...this.guy,
        birthday: new Date(this.guy.birthday).toISOString().split('T')[0] // המרת התאריך לפורמט ISO
      };
      this.personService.addGuy(guy).subscribe(
        (response: Guy) => console.log('Success:', response),
        (error: any) => console.error('Error:', error)
      );
    }
  }
}