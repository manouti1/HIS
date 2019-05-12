import { Component, Inject, OnDestroy, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IPatient } from "../interface/IPatient";
import { Subject } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: "app-fetch-data",
  templateUrl: "./fetch-data.component.html"
})
export class FetchDataComponent implements OnDestroy, OnInit {
  dtOptions: DataTables.Settings = {};
  public patients: IPatient[];
  dtTrigger: Subject = new Subject();
  url: string = '';
  constructor(private http: HttpClient, @Inject("BASE_URL") baseUrl: string, private router: Router) {
    this.url = baseUrl;
  }

  ngOnInit(): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 2
    };

    this.http.get<IPatient[]>(this.url + "api/Patient/ListPatients").subscribe(
      result => {
        this.patients = result;
        this.dtTrigger.next();

      },
      error => console.error(error)
    );

  }

  addNewPatient() {
    this.router.navigate(['new-patient']);

  }

  goToPatientDetails(id) {
    this.router.navigate(['/edit-patient', id]);

  }
  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();

  }
}
