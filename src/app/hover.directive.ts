import { Directive, ElementRef, HostBinding, HostListener, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appHover]',
  standalone: true
})
export class HoverDirective {

  constructor() {}


  @HostBinding('style.backgroundColor') background:string='transparent';

  @HostListener('mouseover') mouseEnter(){
    this.background='red';
  }
  @HostListener('mouseleave') mouseLeave(){
    this.background='transparent';
  }
}
  