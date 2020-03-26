//import { Injectable } from '@angular/core';
//import { Observable } from 'rxjs';
//import 'rxjs/add/operator/map';
//import 'rxjs/add/operator/catch';
//import 'rxjs/add/operator/toPromise';
//import { HttpClient, HttpHeaders, HttpClientModule } from '@angular/common/http';
//import { PatientModel } from './PatientModel';
//import { promise } from 'protractor';

//@Injectable();
//export class PatientService {
//  baseUrl = "http://localhost:5000/api/Patient/CreatePatient";
//  constructor(private http: HttpClient) {

//  }
//  CreatePatient(patientModel: PatientModel): Promise<PatientModel>{
//    let headers = new Headers({ 'content-Type': 'application/json' });
//    return this.http.post(this.baseUrl, patientModel).toPromise().then(this.ExtractData).catch(this.HandleError);
//  }
//    HandleError(error: any): Promise<PatientModel> {
//      console.error(error.message || error);
//      return Promise.reject(error.message || error);
//    }
//    ExtractData(res: any) {
//      let body = res.json();
//      return body || {};
//    }
//}
