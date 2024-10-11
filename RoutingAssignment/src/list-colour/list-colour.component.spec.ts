import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListColourComponent } from './list-colour.component';

describe('ListColourComponent', () => {
  let component: ListColourComponent;
  let fixture: ComponentFixture<ListColourComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ListColourComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListColourComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
