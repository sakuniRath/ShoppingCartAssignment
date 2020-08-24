import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from "@angular/common/http";
import {UserLoginService} from "../shared/user-login.service";

@Injectable({
  providedIn: 'root'
})
export class HttpHelperService {


  constructor(private userLoginS:UserLoginService) { }

 getHeader(){
   console.log(this.userLoginS.getAccessToken());
    let reqHeader=new HttpHeaders({
      "Content-Type":"application/json",
      "Authorization":"Bearer"+this.userLoginS.getAccessToken(),
    });
    console.log(reqHeader);
    return reqHeader;
  }
}
