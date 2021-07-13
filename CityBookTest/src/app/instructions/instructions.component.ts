import { Component, OnInit, Input, Inject } from '@angular/core';
import {FormComponent} from '../form/form.component';
import {UserService} from '../user.service'
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-instructions',
  templateUrl: './instructions.component.html',
  styleUrls: ['./instructions.component.css']
})
export class InstructionsComponent implements OnInit {

 name:string="aaa";

  constructor(
) { }
//@Input() name:any;
  
     title:string="Hello";
  ngOnInit(): void {
  }
  
  

}
