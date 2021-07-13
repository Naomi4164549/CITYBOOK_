import { Component, OnInit,Output ,EventEmitter} from '@angular/core';
import ChildModel from '../models/ChildModel';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {
@Output() completeChild=new EventEmitter<any>();
  fName:string="";
  idntity:string="";
  date:Date=new Date();
  flag: boolean = true;
  child:ChildModel={}as ChildModel;
  constructor() { }

  ngOnInit(): void {
  }
  isValid() {
    // this.isLetters(name)
    // this.isNumbers(name)
    if (this.flag == false)
      alert("Fix the wrong fields")
  }
  isLetters(name: string) {
    var s = /^[A-Za-zא-ת]+$/;
    if (!name.match(s)) {
      console.log('not valid!');
      this.flag = false;
    }
  }
  isNumbers(name: string) {
    var s = /^[0-9]+$/;
    if (!name.match(s)) {
      console.log('not valid2!');
      this.flag = false;
    }
    this.length(name);
  }
  length(name: string) {
    if (name.length < 9)
        this.flag = false;
  }

  saveChild(){
    this.child.fisrtName=this.fName;
    this.child.identity=this.idntity;
    this.child.dateborn=this.date;
    this.completeChild.emit(this.child);
  }

  datefun(date:Date){
    this.date=date;
  }
  fNamefun(fName: string) {
    this.fName = fName;
  }
 
  
  idfun(idntity:string){
    this.idntity=idntity;
  }


}
