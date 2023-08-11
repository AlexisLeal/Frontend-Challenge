import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeBlogerComponent } from './home-bloger.component';

describe('HomeBlogerComponent', () => {
  let component: HomeBlogerComponent;
  let fixture: ComponentFixture<HomeBlogerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HomeBlogerComponent]
    });
    fixture = TestBed.createComponent(HomeBlogerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
