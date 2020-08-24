import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HearderComponentComponent } from './hearder-component.component';

describe('HearderComponentComponent', () => {
  let component: HearderComponentComponent;
  let fixture: ComponentFixture<HearderComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HearderComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HearderComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
