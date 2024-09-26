import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MembershipComponent } from './membership/membership.component';
import { AddEditMembershipComponent } from './membership/add-edit-membership/add-edit-membership.component';
import { ShowMembershipComponent } from './membership/show-membership/show-membership.component';
import { ApiserviceService } from './apiservice.service';
import { DonationComponent } from './donation/donation.component';
import { AddEditDonationComponent } from './donation/add-edit-donation/add-edit-donation.component';
import { ShowMembersDonationComponent } from './donation/show-donation/show-donation.component';

@NgModule({
  declarations: [
    AppComponent,
    MembershipComponent,
    AddEditMembershipComponent,
    ShowMembershipComponent,
    DonationComponent,
    AddEditDonationComponent,
    ShowMembersDonationComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [ApiserviceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
