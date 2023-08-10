import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserAuth } from './models/UserAuthInputModel';

@Injectable({
  providedIn: 'root'
})
export class BlogersService {

  private readonly URL:string = "https://localhost:49418/api/";
  constructor(private readonly  http: HttpClient) { }

  public login(user:UserAuth):Observable<boolean>{
    const URL = `${this.URL}Auth/login`
    return this.http.post<boolean>(URL,user);
  }
}
