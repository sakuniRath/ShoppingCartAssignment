import { Injectable } from '@angular/core';
import { ProductDetail } from './product-detail.model';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ProductDetailService {
  formData:ProductDetail;
  readonly rootURL='http://localhost:49288/api/';
  items = [];
  
  

  constructor(private http:HttpClient) { }

  async getAllProduct() : Promise<Array<ProductDetail>>{
    return await this.http.get<Array<ProductDetail>>(this.rootURL+'ProductList')
    .toPromise();
  }
  addToCart(products) {
    this.items.push(products);
  }

  getItems() {
    return this.items;
  }

  clearCart() {
    this.items = [];
    return this.items;
  }
  removeToCart(pid:number)
  {
     var arrayItem
    arrayItem=this.items.indexOf(pid);
    this.items.splice(arrayItem);
  }

  
}
