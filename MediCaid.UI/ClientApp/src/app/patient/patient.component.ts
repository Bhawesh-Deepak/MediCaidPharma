import { Component, OnInit } from '@angular/core';
import { PatientModel } from '../PatientModel';
import { HttpClient, HttpHeaders, HttpClientModule } from '@angular/common/http';
import { Router, ActivatedRoute, Params } from '@angular/router';

@Component({
  selector: 'app-patient',
  templateUrl: './patient.component.html',
  styleUrls: ['./patient.component.css']
})
export class PatientComponent implements OnInit {

  bloodGroups = ["AB+", "O+", "AB-", "B+", "A-", "B-", "O-"];
  genders = ["Male", "Female", "Other"];
  patientModel: PatientModel;
  userId: number;

  constructor(private http: HttpClient, private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.activatedRoute.queryParams.subscribe(params => {
      debugger;
      this.userId = params["id"];
      this.GetPatientById().subscribe((data: PatientModel) => {
        debugger;
        this.patientModel = data;
      });
    });
    
  }



  PatientSubmit(): void {
    debugger;
    this.CreatePatient().subscribe((data: any) => { alert(data) });
  }

  CreatePatient() {
    return this.http.post("http://localhost:5000/api/Patient/CreatePatient", this.patientModel);
  }

  GetPatientById() {
    return this.http.get("http://localhost:5000/api/Patient/GetPatientById?id=" + this.userId);
  }
}
