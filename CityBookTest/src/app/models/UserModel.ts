import ChildModel from './ChildModel';

export default class UserModel{
    constructor(firstName:string,lastName:string,identity:string,
        dateborn:Date,kind:string,HMO:string,
        numOfChildern:number,children:ChildModel[]){
            this.firstName=firstName;
            this.lastName=lastName;
            this.identity=identity;
            this.dateborn=dateborn;
            this.kind=kind;
            this.HMO=HMO;
            this.numOfChildern=numOfChildern;
            this.childern=children;
    }
    firstName:string;
    lastName:string;
    identity:string;
    dateborn:Date;
    kind:string;
    HMO:string;
    numOfChildern:number;
    childern:ChildModel[];
}