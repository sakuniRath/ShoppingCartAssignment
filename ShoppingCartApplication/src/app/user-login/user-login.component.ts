import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import {UserLogin} from '../shared/user-login.model';
import {UserLoginService} from '../shared/user-login.service';
import {AuthenticateResponse} from '../shared/authenticate-response.model';

@Component({
  selector: 'app-user-login',
  templateUrl: './user-login.component.html',
  styleUrls: []
})
export class UserLoginComponent implements OnInit {
  public loginDetail:AuthenticateResponse;
   public login: UserLogin;
  constructor(public loginservice:UserLoginService) { 
    this.login = new UserLogin();
  }

  ngOnInit(): void {
  }

  resetButton(form:NgForm){
    if(form!=null)form.reset();

  }
  async onSubmit(form:NgForm){
    let usernameKey = 'UserName';
    let tokenKey='Token';
    this.loginservice.postLogin(this.login).subscribe(
      res=>{
        if(res.token!=null){
          localStorage.setItem(tokenKey, res.token);
          localStorage.setItem(usernameKey,res.firstName);
        }
        
        this.resetButton(form);
     },
      err=>{
      console.log(err);
      }
    )

  }

}
