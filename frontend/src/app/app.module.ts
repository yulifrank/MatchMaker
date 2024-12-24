import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomePageComponent } from '../components/home-page/home-page.component';
import { PersonsComponent } from '../components/persons/persons.component';
import { IdeasComponent } from '../components/ideas/ideas.component';
import { TopBarComponent } from '../components/top-bar/top-bar.component'; // הוספת ה-TopBarComponent

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'person', component: PersonsComponent },
  { path: 'ideas', component: IdeasComponent },
];

@NgModule({
  declarations: [

  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
  ],
  providers: [],
  bootstrap: [],
})
export class AppModule {}
