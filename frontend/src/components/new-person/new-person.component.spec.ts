import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPersonComponent } from './new-person.component';

describe('NewPersonComponent', () => {
  let component: NewPersonComponent;
  let fixture: ComponentFixture<NewPersonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewPersonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewPersonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
