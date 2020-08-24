import { Component, OnInit } from '@angular/core';
import {UserLoginService} from '../shared/user-login.service';

@Component({
  selector: 'app-hearder-component',
  templateUrl: './hearder-component.component.html',
  styles: [
  ]
})
export class HearderComponentComponent implements OnInit {
  userDisplayName = '';
  constructor(public loginservice:UserLoginService) {
    this.userDisplayName=this.loginservice.getUserName()
    console.log(this.userDisplayName);
   }

  ngOnInit(): void {
    //this.userDisplayName = sessionStorage.getItem('loggedUser');
    //console.log(this.userDisplayName);
  }

}
