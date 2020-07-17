import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {UserLogin} from './user-login.model';
import {AuthenticateResponse} from './authenticate-response.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserLoginService {
  readonly rootURL='http://localhost:49288/api/';

  constructor(private http:HttpClient) { }

  postLogin(loginR:UserLogin): Observable<AuthenticateResponse>{
    console.log(loginR);

    return this.http.post<AuthenticateResponse>(this.rootURL+'LoginUser',loginR);
  }

  
}
