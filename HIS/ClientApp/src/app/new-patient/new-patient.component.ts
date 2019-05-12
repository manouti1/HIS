import { Component, OnInit, Inject } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-new-patient',
  templateUrl: './new-patient.component.html',
  styleUrls: ['./new-patient.component.css']
})
export class NewPatientComponent implements OnInit {
  patientForm: FormGroup;
  url: string;
  constructor(private formBuilder: FormBuilder, private http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
    this.url = baseUrl;
  }

  ngOnInit() {
    this.patientForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      midName: [''],
      lastName: ['', Validators.required],
      suffix: [''],
      addressLine1: ['', Validators.required],
      addressLine2: ['', Validators.required],
      poBox: ['', Validators.required],
      sex: ['', Validators.required],
      birthDate: ['', Validators.required],
      passportNumber: ['', Validators.required],
      emiratesID: ['', Validators.required],
      workTitle: [''],
      mailAddress: [''],
      mobileNo: ['', Validators.required],
      homeNo: [''],
      workNo: [''],
      phone: [''],
      address: [''],
      relation: [''],
      nationality: ['', Validators.required],
      insuranceCoverage: ['', Validators.required],
      martialStatus: [''],
      hasGuardian: [false, Validators.required]

    });
    this.patientForm.get('hasGuardian').valueChanges.subscribe(
      (hasGuardian: boolean) => {
        if (hasGuardian) {

          this.patientForm.get('phone').setValidators([Validators.required]);
          this.patientForm.get('address').setValidators([Validators.required]);
          this.patientForm.get('relation').setValidators([Validators.required]);

        } else {

          this.patientForm.get('relation').clearValidators();
          this.patientForm.get('address').clearValidators();
          this.patientForm.get('relation').clearValidators();
        }

        this.patientForm.get('phone').updateValueAndValidity();
        this.patientForm.get('address').updateValueAndValidity();
        this.patientForm.get('relation').updateValueAndValidity();
      });
  }
  isChecked() {
    return this.patientForm.get('hasGuardian').value;
  }
  submitPatient(val) {
    
    if (!this.patientForm.valid) {
      alert("Please validate all errors!");
      return;
    }

    this.http.post(this.url + "api/Patient/AddPatient", val)
      .subscribe(
        data => {
          console.log("POST Request is successful ", data);
        },
        error => {

          console.log("Error", error);

        }
      );
  }


}
