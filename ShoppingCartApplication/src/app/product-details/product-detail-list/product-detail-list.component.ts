import { Component, OnInit } from '@angular/core';
import { ProductDetailService } from 'src/app/shared/product-detail.service';
import { ProductDetail } from 'src/app/shared/product-detail.model';

@Component({
  selector: 'app-product-detail-list',
  templateUrl: './product-detail-list.component.html',
  styles: [
  ]
})
export class ProductDetailListComponent implements OnInit {

public products: Array<any>;
  constructor(private _service:ProductDetailService) { }

  async ngOnInit() {
    this.products = await this._service.getAllProduct();
    //console.log(this.products);
    
  }
  public addToCart(product:string) {
    this._service.addToCart(product);
    window.alert('Your product has been added to the cart!');
  }

  public getImageUrl(path: string)
  {
    return "http://localhost:49288"+path;
  }
}
