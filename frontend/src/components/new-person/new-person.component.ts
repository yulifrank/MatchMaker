import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
    standalone:true,
    imports:[    FormsModule ,CommonModule],  // Add FormsModule here
  selector: 'app-new-person',
  templateUrl: './new-person.component.html',
  styleUrls: ['./new-person.component.scss']
})
export class NewPersonComponent {
  person = {
    firstName: '',
    lastName: '',
    birthday: '',
    fatherName: '',
    motherName: '',
    height: null,
    motza: '',
    gender: '',
    subject: '',
    yearbook: null,
    vaad: null,
    img: "",
    resume: ""
  };

  constructor(private http: HttpClient) {}

  onImageChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        this.person.img = reader.result as string;  // כאן נשמור את הנתיב של התמונה
      };
      reader.readAsDataURL(file);  // קוד זה הופך את התמונה לפורמט Base64, כך שנוכל לשלוח אותה כ-URL
    }
  }
  

  onResumeChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        this.person.resume = reader.result as string;  // כאן נשמור את הנתיב של התמונה
      };
      reader.readAsDataURL(file);  // קוד זה הופך את התמונה לפורמט Base64, כך שנוכל לשלוח אותה כ-URL
    }
  }
  
  onSubmit() {
    const formData = new FormData();
    formData.append('firstName', this.person.firstName);
    formData.append('lastName', this.person.lastName);
    formData.append('birthday', this.person.birthday);
    formData.append('fatherName', this.person.fatherName);
    formData.append('motherName', this.person.motherName);
    formData.append('height', String(this.person.height));
    formData.append('motza', this.person.motza);

    if (this.person.gender) {
      formData.append('gender', this.person.gender);
    }
    formData.append('img', this.person.img);
    formData.append('resume', this.person.resume);


    
    this.http.post('http://localhost:5296/api/person', formData, {
      headers: {
        'Accept': 'application/json' // ודאי שהשרת תומך בתשובות JSON
      }
    }).subscribe(
      response => console.log('Success:', response),
      error => console.error('Error:', error)
    );
    
}
}