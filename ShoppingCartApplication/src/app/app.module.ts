import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
//import { ProductDetailComponent } from './product-details/product-detail/product-detail.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { ProductDetailListComponent } from './product-details/product-detail-list/product-detail-list.component';
import { ProductDetailService } from './shared/product-detail.service';
import {HttpClientModule} from '@angular/common/http';
import {CommonModule} from '@angular/common';
import {CustomerDetailService} from './shared/customer-detail.service';

import { Routes, RouterModule } from "@angular/router";

import {
  BrowserAnimationsModule,
  NoopAnimationsModule,
} from "@angular/platform-browser/animations";
import { CartItemsComponent } from './cart-items/cart-items.component';
import { CustomerRegistrationComponent } from './customer-registration/customer-registration.component';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { UserLoginComponent } from './user-login/user-login.component';
import { HearderComponentComponent } from './hearder-component/hearder-component.component';
import { FooterComponentComponent } from './footer-component/footer-component.component';
import { PaymentConfirmationComponent } from './payment-confirmation/payment-confirmation.component';


const routes: Routes = [
  { path: "", component: ProductDetailsComponent },
  { path: "cart-items", component: CartItemsComponent },
  { path: "customer-registration", component: CustomerRegistrationComponent },
  { path: "user-login", component: UserLoginComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    //ProductDetailComponent,
    ProductDetailsComponent,
    ProductDetailListComponent,
    CartItemsComponent,
    CustomerRegistrationComponent,
    UserLoginComponent,
    HearderComponentComponent,
    FooterComponentComponent,
    PaymentConfirmationComponent,
    
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    CommonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ProductDetailService,CustomerDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
