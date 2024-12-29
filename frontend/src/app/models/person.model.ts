export interface Person {
  id:number;
  firstName: string;
  lastName: string;
  birthday: string;
  opennessLevel: number;
  fatherName: string;
  motherName: string;
  height: number;
  motza: number;
  remark?: string;
  resume?: string;
  img?: string;
}

export enum Motza {
  Ashcenaz = 0,
  Sfarad = 1,
  Chasid = 2,
  Teman = 3
}

export interface Guy extends Person {
  vaad: number | null;
}

export interface Girl extends Person {
  subject: string;
  yearbook: number;
}

