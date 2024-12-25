import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from '../components/home-page/home-page.component';
import { PersonsComponent } from '../components/persons/persons.component';
import { IdeasComponent } from '../components/ideas/ideas.component';
//  import { NewPersonComponent } from '../components/new-person/new-person.component';

export const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'person', component: PersonsComponent },
  { path: 'ideas', component: IdeasComponent },
  //  { path:'new',component:NewPersonComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
