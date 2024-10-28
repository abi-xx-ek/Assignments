import { style } from '@angular/animations';
import { Directive, ElementRef, Host, HostBinding, HostListener, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appHoverColour]',
  standalone: true
})
export class HoverColourDirective {

  constructor(private element:ElementRef,renderer:Renderer2) {}


  @HostBinding('style.backgroundColor') background:string='';

  @HostListener('mouseenter') mouseEnter(){
    this.background='blue';
  }
  @HostListener('mouseleave') mouseLeave(){
    this.background='blue';
  }
  

}
