
// import { Component } from '@angular/core';
// import { Person, Girl, Guy } from './person.model';  

// @Component({
//   selector: 'app-new-person',
//   templateUrl: './new-person.component.html',
//   styleUrls: ['./new-person.component.css']
// })
// export class NewPersonComponent {
//   person: Person = new Person();
//   export class Person {
//     subject: string;
//     yearbook: number;
//     vaad: number;
//     firstName: string;
//     lastName: string;
//     birthday: string; // או Date תלוי איך אתה רוצה לנהל תאריך
//     fatherName: string;
//     motherName: string;
//     hight: number;
//     motza: string;
//   }
  
//   onSubmit() {
//     if (this.person.gender === 'Girl') {
//       // יצירת אובייקט Girl עם הפרטים שהוזנו
//       const newGirl = new Girl(
//         this.person.firstName,
//         this.person.lastName,
//         new Date(this.person.birthday),  // המרת תאריך
//         this.person.opennessLevel,
//         this.person.fatherName,
//         this.person.motherName,
//         this.person.hight,
//         this.person.motza,
//         this.person.subject,
//         this.person.yearbook,
//         this.person.remark,
//         this.person.resume,
//         this.person.img
//       );
//       console.log(newGirl);  // הדפס את האובייקט על מנת לבדוק
//     } else if (this.person.gender === 'Guy') {
//       // יצירת אובייקט Guy עם הפרטים שהוזנו
//       const newGuy = new Guy(
//         this.person.firstName,
//         this.person.lastName,
//         new Date(this.person.birthday),  // המרת תאריך
//         this.person.opennessLevel,
//         this.person.fatherName,
//         this.person.motherName,
//         this.person.hight,
//         this.person.motza,
//         this.person.vaad,
//         this.person.remark,
//         this.person.resume,
//         this.person.img
//       );
//       console.log(newGuy);  // הדפס את האובייקט על מנת לבדוק
//     }
//   }
// }
