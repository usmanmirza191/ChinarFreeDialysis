import { Component, OnInit, Input } from '@angular/core';
import { ApiserviceService } from '../../../../src/app/apiservice.service';


@Component({
  selector: 'app-add-edit-membership',
  templateUrl: './add-edit-membership.component.html',
  styleUrl: './add-edit-membership.component.css'
})
export class AddEditMembershipComponent implements OnInit {
  constructor(private service: ApiserviceService) { }

  @Input() member: any;
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

    this.Id = this.member.Id;
    this.FirstName = this.member.FirstName;
    this.LastName = this.member.LastName;
    this.MobileNo = this.member.MobileNo;
    this.WhatsappNo = this.member.WhatsappNo;
    this.Email = this.member.Email;
    this.CNIC = this.member.CNIC;
    this.Address = this.member.Address;
    this.MembershipDate = this.member.MembershipDate;
  }

  addMember() {
    var member = {
      Id: this.Id,
      FirstName: this.FirstName,
      LastName: this.LastName,
      MobileNo: this.MobileNo,
      WhatsappNo: this.WhatsappNo,
      Email : this.Email,
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
