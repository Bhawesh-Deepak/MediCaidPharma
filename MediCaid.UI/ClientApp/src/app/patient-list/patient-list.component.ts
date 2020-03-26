import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { PatientModel } from '../PatientModel';

@Component({
  selector: 'app-patient-list',
  templateUrl: './patient-list.component.html',
  styleUrls: ['./patient-list.component.css']
})

export class PatientListComponent implements OnInit {

  constructor(private http: HttpClient) {
  }
  patientModels: PatientModel[];

  ngOnInit() {
    this.GetPatientList().subscribe((data: []) => {
      console.log(data);
      debugger;
      this.patientModels = data
    });
  }

  GetPatientList() {
    return this.http.get("http://localhost:5000/api/Patient/GetPatients");
  }
}
