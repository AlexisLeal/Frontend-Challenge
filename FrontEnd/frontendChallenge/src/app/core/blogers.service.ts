import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserAuth } from './models/UserAuthInputModel';
import { IAllBlogerOutputModel } from './models/Bloger.interface';

@Injectable({
  providedIn: 'root'
})
export class BlogersService {

  private readonly URL:string = "https://localhost:50075/api/";
  constructor(private readonly  http: HttpClient) { }

  public login(user:UserAuth):Observable<boolean>{
    const URL = `${this.URL}Auth/login`
    return this.http.post<boolean>(URL,user);
  }

  public GetAllBlogers():Observable<IAllBlogerOutputModel[]>{
    const URL = `${this.URL}Bloger/GetAllBlogers`
    return this.http.get<IAllBlogerOutputModel[]>(URL); 
  }
}
