export interface IPatient {
  Id: number;
  FirstName: string;
  MidName: string;
  LastName: string;
  Suffix: string;
  AddressLine1: string;
  AddressLine2: string;
  POBox: string;
  Sex: string;
  DateOfBirth: Date;
  PassportNumber: string;
  EmiratesID: string;
  WorkTitle: string;
  MailAddress: string;
  MobilePhone: string;
  HomePhone: string;
  WorkPhone: string;
  HasGaurdian: boolean;
  Nationality: string;
  InsuranceCoverage: string;
  MartialStatus: string;
  Guardian: Guardian;
}

class Guardian {
  Phone: string;
  Address: string;
  Relation: string;
  PatientID: number;
}
