export class Person {
    constructor(
      public firstName: string = '',
      public lastName: string = '',
      public birthday: string = '',
      public opennessLevel: number = 0,
      public fatherName: string = '',
      public motherName: string = '',
      public hight: number = 0,
      public motza: string = 'Ashcenaz',
      public remark: string = '',
      public resume: string = '',
      public img: string = '',
      public gender: string = 'Girl'
    ) {}
  }
  
  export class Girl extends Person {
    constructor(
      public subject: string = '',
      public yearbook: number = 0,
      firstName: string = '',
      lastName: string = '',
      birthday: string = '',
      opennessLevel: number = 0,
      fatherName: string = '',
      motherName: string = '',
      hight: number = 0,
      motza: string = 'Ashcenaz',
      remark: string = '',
      resume: string = '',
      img: string = ''
    ) {
      super(firstName, lastName, birthday, opennessLevel, fatherName, motherName, hight, motza, remark, resume, img);
    }
  }
  
  export class Guy extends Person {
    constructor(
      public vaad: number = 0,
      firstName: string = '',
      lastName: string = '',
      birthday: string = '',
      opennessLevel: number = 0,
      fatherName: string = '',
      motherName: string = '',
      hight: number = 0,
      motza: string = 'Ashcenaz',
      remark: string = '',
      resume: string = '',
      img: string = ''
    ) {
      super(firstName, lastName, birthday, opennessLevel, fatherName, motherName, hight, motza, remark, resume, img);
    }
  }
  