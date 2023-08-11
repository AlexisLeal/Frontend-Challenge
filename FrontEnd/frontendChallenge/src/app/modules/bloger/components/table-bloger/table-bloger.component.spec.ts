import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TableBlogerComponent } from './table-bloger.component';

describe('TableBlogerComponent', () => {
  let component: TableBlogerComponent;
  let fixture: ComponentFixture<TableBlogerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TableBlogerComponent]
    });
    fixture = TestBed.createComponent(TableBlogerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
