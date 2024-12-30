import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Girl, Guy, Person } from '../models/person.model';

@Injectable({
  providedIn: 'root',
})
export class PersonService {
  private apiUrl = 'http://localhost:5296/api/Person';

  constructor(private http: HttpClient) {}

  getGuys(): Observable<Guy[]> {
    return this.http.get<Guy[]>(`${this.apiUrl}/guys`);
  }

  getGirls(): Observable<Girl[]> {
    return this.http.get<Girl[]>(`${this.apiUrl}/girls`);
  }

  getPersonById(id: number): Observable<Person> {
    return this.http.get<Person>(`${this.apiUrl}/${id}`);
  }

  addGuy(guy: Guy): Observable<Guy> {
    return this.http.post<Guy>(`${this.apiUrl}/addGuy`, guy);
  }

  addGirl(girl: Girl): Observable<Girl> {
    return this.http.post<Girl>(`${this.apiUrl}/addGirl`, girl);
  }

  updatePerson(id: number, person: Person): Observable<Person> {
    return this.http.put<Person>(`${this.apiUrl}/${id}`, person);
  }

  deletePerson(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
