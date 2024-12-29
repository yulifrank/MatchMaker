import { Girl, Guy } from "../../components/new-person/person.model";

export interface Idea {
  id: number;
  guyId: number;
  girlId: number;
  girl:Girl
  guy:Guy
  statusDescription: string;
  
}

export interface IdeaPostModel {
  guyId: number;
  girlId: number;
  statusDescription: string;
  
}


