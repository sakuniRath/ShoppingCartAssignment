import { Injectable } from '@angular/core';
import { CustomerDetail } from './customer-detail.model';
import {HttpClient} from '@angular/common/http'



@Injectable({
  providedIn: 'root'
})
export class CustomerDetailService {
  formData:CustomerDetail
  readonly rootURL='http://localhost:49288/api/';

  constructor(private http:HttpClient) { 
    
  }
  PostCustomer(customerR:CustomerDetail){
    //var body=JSON.stringify(customerR);
    //var headeroptions=new Headers ({'content-Type':'application/json'});
    //var requstoptions=new RequestOptions ({method:RequstMethod.Post,header:headeroptions});
    //return this.http.post('',body,requstoptions).map(x=>x.json)
    return this.http.post(this.rootURL+'Customer',customerR);
  }
}
