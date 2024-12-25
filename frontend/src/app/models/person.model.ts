export interface Person {
    id: number;
    firstName: string;
    lastName: string;
    birthday: string;
    opennessLevel: number;
    fatherName: string;
    motherName: string;
    height: number;
    motza: Motza;
    remark?: string;
    resume?: string;
    img?: string;
  }
  export enum Motza {
    Ashcenaz = 'אשכנז',
    Sfarad = 'ספרד',
    Chasid = 'חסיד',
    Teman = 'תימן'
  }
  
  
  export interface Guy extends Person {
    vaad: number;
  }
  
  export interface Girl extends Person {
    subject: string;
    yearbook: number;
  }
  