import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders ,HttpParams} from '@angular/common/http'
import {FormComponent} from './form/form.component'
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  private userUrl = 'api/userList';

  getUser(): Observable<FormComponent[]> {
    return this.http.get<FormComponent[]>(this.userUrl)
  }

  User(id: number): Observable<FormComponent> {
    const url = `${this.userUrl}/${id}`;
    return this.http.get<FormComponent>(url);
  }

  addUser(user: FormComponent): Observable<any> {
    return this.http.post<any>(this.userUrl, user, this.httpOptions)
  }

  updateUser(user: FormComponent): Observable<any> {
    return this.http.put(this.userUrl, user, this.httpOptions);
  }

  deleteUser(user: any | number): Observable<any> {
    const id = typeof user === 'number' ? user : user.id;
    const url = `${this.userUrl}/${id}`;
    return this.http.delete<FormComponent>(url, this.httpOptions)
  }

  constructor(private http: HttpClient) { }
}


