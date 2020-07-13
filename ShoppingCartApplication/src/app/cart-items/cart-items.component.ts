import { Component, OnInit } from '@angular/core';
import { ProductDetailService } from 'src/app/shared/product-detail.service';

@Component({
  selector: 'app-cart-items',
  templateUrl: './cart-items.component.html',
  styleUrls: []
})
export class CartItemsComponent implements OnInit {
  items;

  constructor(private _service:ProductDetailService) { }

  ngOnInit(): void {
    this.items = this._service.getItems();
    console.log(this.items);
  }
  public getImageUrl(path: string)
  {
    return "http://localhost:49288"+path;
  }

  public removeToCart(pid:number)
  {
    this._service.removeToCart(pid);
  }

}
