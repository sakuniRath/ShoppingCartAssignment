import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from '../shared/customer-detail.service';
import { CustomerDetail} from '../shared/customer-detail.model';
import { NgForm } from '@angular/forms';



@Component({
  selector: 'app-customer-registration',
  templateUrl: './customer-registration.component.html',
  styles: [
  ]
})
export class CustomerRegistrationComponent implements OnInit {

  error: string;
  public registerUser:CustomerDetail;
  constructor(public customerservice:CustomerDetailService) { 
    this.registerUser=new CustomerDetail();
  }
  
  ngOnInit(): void {
    
    
  }
  resetButton(form :NgForm){

    if(form !=null)form.reset();
    
  }
  onSubmit(form:NgForm)
  {if(form.value.customerId==null){
    this.customerservice.PostCustomer(this.registerUser).subscribe( 
      res =>{
      this.resetButton(form);
    },
    err=>{
      console.log(err);
    }
    )
  }

  }

}
