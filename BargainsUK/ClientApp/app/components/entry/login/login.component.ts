import { Component, Inject } from '@angular/core';
import { LoginService } from '../../../services/login.service';


@Component({
    selector: 'login',
    templateUrl: './login.component.html'
})

export class LoginComponent{



    constructor(loginService:LoginService) 
    {
        

    }

    public login(){
       
    }
}