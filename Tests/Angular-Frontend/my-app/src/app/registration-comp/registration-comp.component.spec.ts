import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrationCompComponent } from './registration-comp.component';

describe('RegistrationCompComponent', () => {
  let component: RegistrationCompComponent;
  let fixture: ComponentFixture<RegistrationCompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RegistrationCompComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RegistrationCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
