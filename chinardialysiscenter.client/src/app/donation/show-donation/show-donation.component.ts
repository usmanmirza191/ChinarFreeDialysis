import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from '../../../../src/app/apiservice.service';

@Component({
  selector: 'app-show-donation',
  templateUrl: './show-donation.component.html',
  styleUrl: './show-donation.component.css'
})
export class ShowMembersDonationComponent implements OnInit {
  constructor(private service: ApiserviceService) { }

  MembersDonationList: any = [];
  ModalTitle = "";
  ActivateAddEditMembersDonationComp: boolean = false;
  memberDonation: any;

  MembersDonationIdFilter = "";
  MembersDonationNameFilter = "";
  MembersDonationListWithoutFilter: any = [];

  ngOnInit(): void {
    this.refreshMembersDonationList();
  }

  addClick() {
    this.memberDonation = {
      Id: 0,
      DonatedBy: "",
      ReceivedBy: "",
      Amount: "",
      DonationSource: "",
      DonationReceipt: ""
    }
    this.ModalTitle = "Add Members Donation";
    this.ActivateAddEditMembersDonationComp = true;
  }

  editClick(item: any) {
    this.memberDonation = item;
    this.ModalTitle = "Edit Members Donation";
    this.ActivateAddEditMembersDonationComp = true;
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.service.deleteMembersDonation(item.Id).subscribe((data: any) => {
        alert(data.toString());
        //this.toastr.success("Deleted successfully");
        this.refreshMembersDonationList();
      })
    }
  }

  closeClick() {
    this.ActivateAddEditMembersDonationComp = false;
    this.refreshMembersDonationList();
  }


  refreshMembersDonationList() {
    this.service.getMembersDonation().subscribe((data: any) => {
      this.MembersDonationList = data;
      this.MembersDonationListWithoutFilter = data;
    });
  }

  sortResult(prop: any, asc: any) {
    this.MembersDonationList = this.MembersDonationListWithoutFilter.sort(function (a: any, b: any) {
      if (asc) {
        return (a[prop] > b[prop]) ? 1 : ((a[prop] < b[prop]) ? -1 : 0);
      }
      else {
        return (b[prop] > a[prop]) ? 1 : ((b[prop] < a[prop]) ? -1 : 0);
      }
    });
  }

  FilterFn() {
    var MemberDonationIdFilter = this.MembersDonationIdFilter;
    var MembersDonationNameFilter = this.MembersDonationNameFilter;

    this.MembersDonationList = this.MembersDonationListWithoutFilter.filter(
      function (el: any) {
        return el.MemberId.toString().toLowerCase().includes(
          MemberDonationIdFilter.toString().trim().toLowerCase()
        ) &&
          el.FirstName.toString().toLowerCase().includes(
            MembersDonationNameFilter.toString().trim().toLowerCase())
      }
    );
  }
}

