import { Component, OnInit } from '@angular/core';
import { ApiserviceService } from '../../../../src/app/apiservice.service';


@Component({
  selector: 'app-show-membership',
  templateUrl: './show-membership.component.html',
  styleUrl: './show-membership.component.css'
})
export class ShowMembershipComponent implements OnInit {
  constructor(private service: ApiserviceService) { }

  MemberList: any = [];
  ModalTitle = "";
  ActivateAddEditMemberComp: boolean = false;
  member: any;

  MemberIdFilter = "";
  MemberNameFilter = "";
  MemberListWithoutFilter: any = [];

  ngOnInit(): void {
    this.refreshMembersList();
  }

  addClick() {
    this.member = {
      Id: 0,
      FirstName: "",
      LastName: "",
      MobileNo: "",
      WhatsappNo: "",
      CNIC: "",
      Address: "",
      MembershipDate: ""
    }
    this.ModalTitle = "Add Member";
    this.ActivateAddEditMemberComp = true;
  }

  editClick(item: any) {
    this.member = item;
    this.ModalTitle = "Edit Member";
    this.ActivateAddEditMemberComp = true;
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.service.deleteMembership(item.Id).subscribe((data: any) => {
        alert(data.toString());
        //this.toastr.success("Deleted successfully");
        this.refreshMembersList();
      })
    }
  }

  closeClick() {
    this.ActivateAddEditMemberComp = false;
    this.refreshMembersList();
  }


  refreshMembersList() {
    this.service.getMembersList().subscribe((data: any) => {
      this.MemberList = data;
      this.MemberListWithoutFilter = data;
    });
  }

  sortResult(prop: any, asc: any) {
    this.MemberList = this.MemberListWithoutFilter.sort(function (a: any, b: any) {
      if (asc) {
        return (a[prop] > b[prop]) ? 1 : ((a[prop] < b[prop]) ? -1 : 0);
      }
      else {
        return (b[prop] > a[prop]) ? 1 : ((b[prop] < a[prop]) ? -1 : 0);
      }
    });
  }

  FilterFn() {
    var MemberIdFilter = this.MemberIdFilter;
    var MemberNameFilter = this.MemberNameFilter;

    this.MemberList = this.MemberListWithoutFilter.filter(
      function (el: any) {
        return el.MemberId.toString().toLowerCase().includes(
          MemberIdFilter.toString().trim().toLowerCase()
        ) &&
          el.FirstName.toString().toLowerCase().includes(
            MemberNameFilter.toString().trim().toLowerCase())
      }
    );
  }
}
