import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root' // Add this line
})

export class IdeaService {
  private apiUrl = 'http://localhost:5296/api/Idea';

  constructor(private http: HttpClient) { }


  getIdeas(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }

  getIdeaById(id: number): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${id}`);
  }

  addIdea(idea: any): Observable<any> {
    return this.http.post<any>(this.apiUrl, idea);
  }

  updateIdea(id: number, idea: any): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/${id}`, idea);
  }

  deleteIdea(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
