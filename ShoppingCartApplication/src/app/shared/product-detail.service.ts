import { Injectable } from '@angular/core';
import { ProductDetail } from './product-detail.model';
import {HttpClient,HttpHeaders} from '@angular/common/http'
import { Observable } from 'rxjs';
import {StockMessage} from '../shared/stock-message.model';
import {HttpHelperService} from '../shared/http-helper.service';

@Injectable({
  providedIn: 'root'
})
export class ProductDetailService {
  formData:ProductDetail;
  readonly rootURL='http://localhost:49288/api/';
  items = [];
  
  

  constructor(private http:HttpClient,private httphelp:HttpHelperService) { }

  async getAllProduct() : Promise<Array<ProductDetail>>{
    return await this.http.get<Array<ProductDetail>>(this.rootURL+'ProductList')
    .toPromise();
  }
  addToCart(products) {
    let index = this.items.findIndex(d => d.productId === products.productId);
    if(index >= 0)
    {
      this.items.splice(index, 1);
      products.selectedItemCount=products.selectedItemCount+1
      this.items.push(products);
    }
    else
    {
      this.items.push(products);
    }
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
    //arrayItem=this.items.filter(x => x.productId !== pid)
    
    let index = this.items.findIndex(d => d.productId === pid);
    this.items.splice(index, 1);
    //this.items.forEach( (item, index) => {
      //if(item === pid) this.items.splice(index,1);
    //});
  }

  getTotalPrice(){
    let total=0;
    this.items.map(item=>{total +=item.unitPrice * item.selectedItemCount});
    return total;
  }

  postCheckOut(productItem:ProductDetail[]):Observable<StockMessage>{
    //console.log(loginR);
    console.log(this.httphelp.getHeader());
    return this.http.post<StockMessage>(this.rootURL+'CheckOut',productItem,{headers:this.httphelp.getHeader()});
  }


 

  
}
