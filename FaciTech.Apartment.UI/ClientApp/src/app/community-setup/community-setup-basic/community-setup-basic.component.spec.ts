import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunitySetupBasicComponent } from './community-setup-basic.component';

describe('CommunitySetupBasicComponent', () => {
  let component: CommunitySetupBasicComponent;
  let fixture: ComponentFixture<CommunitySetupBasicComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CommunitySetupBasicComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CommunitySetupBasicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
