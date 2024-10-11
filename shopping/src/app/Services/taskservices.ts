import { EventEmitter, Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";

@Injectable({

    providedIn: 'root'
})
export class taskservice{

private countsub=new BehaviorSubject<number>(0);
createemitter= new EventEmitter<string>();

count$=this.countsub.asObservable();

increment()
{
    this.countsub.next(this.countsub.value+1);
}
decrement()
{
    this.countsub.next(this.countsub.value-1);
}

Oncreate(value:string)
{
    this.createemitter.emit(value);    
}
}