import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowMembersDonationComponent } from './show-donation.component';

describe('ShowDonationComponent', () => {
  let component: ShowMembersDonationComponent;
  let fixture: ComponentFixture<ShowMembersDonationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ShowMembersDonationComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ShowMembersDonationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
