import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAndFieldComponent } from './form-and-field.component';

describe('FormAndFieldComponent', () => {
  let component: FormAndFieldComponent;
  let fixture: ComponentFixture<FormAndFieldComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAndFieldComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAndFieldComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
