import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';  // ודא ש-`RouterModule` מיובא
import { AppComponent } from './app.component';
import { HomePageComponent } from '../components/home-page/home-page.component';
import { PersonsComponent } from '../components/persons/persons.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PersonsComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([  // ודא שהגדרת את ה-`RouterModule` בצורה זו
      { path: '', component: HomePageComponent },
      { path: 'person', component: PersonsComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
