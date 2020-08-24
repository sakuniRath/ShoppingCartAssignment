import { Component, OnInit } from '@angular/core';
import { ProductDetailService } from 'src/app/shared/product-detail.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-cart-items',
  templateUrl: './cart-items.component.html',
  styleUrls: []
})
export class CartItemsComponent implements OnInit {
  items;
  public totalAmount;
  public itemTotal:number;
  

  constructor(private _service:ProductDetailService) { }

  ngOnInit(): void {
    this.items = this._service.getItems();
    this.getTotalAmount();
  }
  public getImageUrl(path: string)
  {
    return "http://localhost:49288"+path;
  }

  public removeToCart(pid:number)
  {
    this._service.removeToCart(pid);
  }

  getTotalAmount(){
     return this.totalAmount=this._service.getTotalPrice();
  }

  getItemTotal(pid:number){
    //console.log(pid);
    var changedItem=this.items.filter(x => x.productId == pid)
    //console.log(changedItem);
    this.itemTotal=changedItem[0].selectedItemCount *changedItem[0].unitPrice;
    //console.log(changedItem[0].selectedItemCount);
    //console.log(changedItem[0].unitPrice);
    //console.log(this.itemTotal);
    this.getTotalAmount();
    //console.log(this.totalAmount);
    

  }
  CheckItemCount(){
    console.log(this.items);
    var selectedItems=this.items;
    this._service.postCheckOut(selectedItems).subscribe(
      res=>{
        console.log(res.stockMessage);
        window.alert(res.stockMessage);
     },
      err=>{
      console.log(err);
      }
    )
  }
  

}
