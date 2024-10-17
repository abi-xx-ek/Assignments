import { Directive, TemplateRef, ViewContainerRef,Input } from '@angular/core';

@Directive({
  selector: '[appEmail]',
  standalone: true
})
export class EmailDirective {

  constructor(private template:TemplateRef<any>,private view:ViewContainerRef) {}
  
  @Input() set appEmail(email: string) {
    if (email.endsWith('@gmail.com')) {
      this.view.createEmbeddedView(this.template);
    } else {
      this.view.clear();
    }
  }
  
  }


