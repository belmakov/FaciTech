import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class FaciTechService {
  baseUrl: string
  constructor(private http:HttpClient) {
    this.baseUrl = 'https://localhost:44316/api/';
  }
  fullUrl(endpoint: string) {
    return this.baseUrl + endpoint;
  }
  get<T>(endpoint:string) : Observable<T> {
    return this.http.get<T>(this.fullUrl(endpoint));
  }
  post<T>(endpoint: string,model:any): Observable<T> {
    return this.http.post<T>(this.fullUrl(endpoint),model);
  }
  put<T>(endpoint: string, model: any): Observable<T> {
    return this.http.put<T>(this.fullUrl(endpoint), model);
  }
}
