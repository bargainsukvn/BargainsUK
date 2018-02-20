import { Injectable } from '@angular/core';

@Injectable()
export class LoginService {

    constructor() { }

    autenticateUser(): User {
        let user = { firstname: 'adrise', lastname: 'younis', username: '123' };
        return user;
    }
}

interface User {
    firstname: string;
    lastname: string;
    username: string;
}