import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Customers } from '../app/models/customers'
import { environment } from 'src/environments/environment';


@Injectable()

export class DataService {

  endPoint: string = "api/Customers/"
  //url = environment.apiUrl + this.endPoint;

  constructor(private http: HttpClient) { }

  getAll(): Observable<any> {
    return this.http.get<any>(this.endPoint)
  }

  Delete(id: number): Observable<any> {
    let idStr: string = '{' + id + '}';
    return this.http.delete<any>(this.endPoint + idStr)
  }

  GetById(id: string): Observable<any> {

    let idStr: string = '{' + id + '}';
    return this.http.get<any>('/api/Customers' + idStr)
  }

  Put(customer: Customers): Observable<any> {
    return this.http.put<any>('/api/Customers', customer);
  }

  Post(customer: Customers): Observable<any> {

    return this.http.post<any>('/api/Customers', customer);


  }

}

