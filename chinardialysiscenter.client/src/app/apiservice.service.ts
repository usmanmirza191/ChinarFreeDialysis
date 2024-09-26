import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly apiUrl = 'https://localhost:7122/api/';
  constructor(private http: HttpClient) { }

  // Members
  getMembersList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'GetMembers');
  }
  addMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'AddMember', member, httpOptions);
  }

  updateMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<any>(this.apiUrl + 'UpdateMember/', member, httpOptions);
  }

  deleteMembership(memberId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + 'DeleteMember/' + memberId, httpOptions);
  }
  // Donation
  getMembersDonation(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'MembersDonations');
  }
  addMembersDonation(membersDonation: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'SaveMembersDonation', membersDonation, httpOptions);
  }

  updateMemberDonation(membersDonation: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<any>(this.apiUrl + 'UpdateMembersDonation/', membersDonation, httpOptions);
  }

  deleteMembersDonation(donationId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + 'DeleteMembersDonation/' + donationId, httpOptions);
  }
}
