import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomePageComponent } from '../components/home-page/home-page.component';
import { PersonsComponent } from '../components/persons/persons.component';
import { IdeasComponent } from '../components/ideas/ideas.component';
// import {NewPersonComponent} from '../components/new-person/new-person.component'
import { FormsModule } from '@angular/forms'; // הוסף את זה
import { CommonModule } from '@angular/common';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'person', component: PersonsComponent },
  { path: 'ideas', component: IdeasComponent },
  // {path:'new',component:NewPersonComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PersonsComponent,
    IdeasComponent,
    // NewPersonsComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    FormsModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [],
})
export class AppModule {}
