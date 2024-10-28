import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DropdownPipeComponent } from './dropdown-pipe.component';

describe('DropdownPipeComponent', () => {
  let component: DropdownPipeComponent;
  let fixture: ComponentFixture<DropdownPipeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DropdownPipeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DropdownPipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
