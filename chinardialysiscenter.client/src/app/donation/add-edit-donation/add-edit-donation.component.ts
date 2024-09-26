import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from '../../../../src/app/apiservice.service';

@Component({
  selector: 'app-add-edit-donation',
  templateUrl: './add-edit-donation.component.html',
  styleUrl: './add-edit-donation.component.css'
})
export class AddEditDonationComponent implements OnInit {
  constructor(private service: ApiserviceService) { }

  @Input() memberDonation: any;
  Id = 0;
  FirstName = "";
  LastName = "";
  MobileNo = "";
  WhatsappNo = "";
  CNIC = "";
  Address = "";
  Email = "";
  MembershipDate = new Date().toISOString().substring(0, 10);

  ngOnInit(): void {

    this.Id = this.memberDonation.Id;
    this.FirstName = this.memberDonation.FirstName;
    this.LastName = this.memberDonation.LastName;
    this.MobileNo = this.memberDonation.MobileNo;
    this.WhatsappNo = this.memberDonation.WhatsappNo;
    this.Email = this.memberDonation.Email;
    this.CNIC = this.memberDonation.CNIC;
    this.Address = this.memberDonation.Address;
    this.MembershipDate = this.memberDonation.MembershipDate;
  }

  addMember() {
    var member = {
      Id: this.Id,
      FirstName: this.FirstName,
      LastName: this.LastName,
      MobileNo: this.MobileNo,
      WhatsappNo: this.WhatsappNo,
      Email: this.Email,
      CNIC: this.CNIC,
      Address: this.Address,
      MembershipDate: new Date().toISOString().substring(0, 10),
    };
    this.service.addMembership(member).subscribe(res => {
      //if (res)
      //  this.toastr.success('Member added successfully.');
    });
  }

  updateMember() {
    var member = {
      Id: this.Id,
      FirstName: this.FirstName,
      LastName: this.LastName,
      MobileNo: this.MobileNo,
      WhatsappNo: this.WhatsappNo,
      Email: this.Email,
      CNIC: this.CNIC,
      Address: this.Address,
      MembershipDate: this.MembershipDate,
    };
    this.service.updateMembership(member).subscribe(res => {
      //if (res)
      //  this.toastr.success('Member updated successfully.');
    });
  }
}
