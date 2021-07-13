import { Injectable } from '@angular/core';
import {FormComponent} from './form/form.component'

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService {

  createDb() {
    
    const userList=[
      {
        fName:'Yaakov',
        lName:'Levy',
        identity:'3242432568',
        databorn:'23/14/2001',
        kind:'male',
        HMO:'Macabbi',
        numChildren:5
      }
    ]
    
    
    return {userList};
  }

  constructor() { }

  // genId(user: FormComponent[]): number {
  //       return user.length > 0 ? Math.max(...user.map(user => user.id)) + 1 : 1;
  // }
}
