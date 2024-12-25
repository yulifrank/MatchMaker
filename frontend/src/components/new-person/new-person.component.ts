// import { Component } from '@angular/core';
// import { Person, Girl, Guy } from './person.model';

// @Component({
//   selector: 'app-new-person',
//   templateUrl:'./new-person.component.html',
//   styleUrls: ['./new-person.component.scss']
// })
// export class NewPersonComponent {
//   person: Person = new Person();

//   onSubmit() {
//     if (this.person.gender === 'Girl') {
//       const newGirl = new Girl(
//         this.person.firstName!,
//         this.person.lastName!,
//         new Date(this.person.birthday!),
//         this.person.fatherName!,
//         this.person.motherName!,
//         this.person.height!,
//         this.person.motza!,
//         this.person.subject!,
//         this.person.yearbook!,
//         this.person.remark,
//         this.person.resume,
//         this.person.img
//       );
//       console.log('Girl created:', newGirl);
//     } else if (this.person.gender === 'Guy') {
//       const newGuy = new Guy(
//         this.person.firstName!,
//         this.person.lastName!,
//         new Date(this.person.birthday!),
//         this.person.fatherName!,
//         this.person.motherName!,
//         this.person.height!,
//         this.person.motza!,
//         this.person.vaad!,
//         this.person.remark,
//         this.person.resume,
//         this.person.img
//       );
//       console.log('Guy created:', newGuy);
//     }
//   }
// }
