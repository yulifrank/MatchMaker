import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router'; // הוספת המודול הזה
import { AppComponent } from './app.component';
import { HomePageComponent } from '../components/home-page/home-page.component';
import { PersonsComponent } from '../components/persons/persons.component';

const routes = [
  { path: '', component: HomePageComponent },
  { path: 'person', component: PersonsComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PersonsComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes), // הוספת RouterModule עם הגדרת הראוטים
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
