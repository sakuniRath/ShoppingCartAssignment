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

  constructor(public customerservice:CustomerDetailService) { }
  error: string;
  ngOnInit(): void {
    
    
  }
  resetButton(form :NgForm){

    if(form !=null)form.reset();
    this.customerservice.formData={
    customerId:null,
      firstName:'',
      lastName:'',
      phoneNumber:'',
      email:'',
      password:'',
      address:'',

    }
  }
  onSubmit(form:NgForm)
  {if(form.value.customerId==null){
    this.customerservice.PostCustomer(form.value).subscribe( 
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
