import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunitySetupComponent } from './community-setup.component';

describe('CommunitySetupComponent', () => {
  let component: CommunitySetupComponent;
  let fixture: ComponentFixture<CommunitySetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CommunitySetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CommunitySetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
