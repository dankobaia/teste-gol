import { Data } from "@angular/router";

export class AirplaneModel {
  public Id: string;
  public Model: string;
  public MaxPassengers: number;
  public CreateDate: Data;
  public Editing: boolean;

  constructor(item: any) {
    if (item == null) {
      this.Editing = true;
      return
    }
    this.Id = item.id;
    this.Model = item.model;
    this.MaxPassengers = item.maxPassengers;
    this.CreateDate = item.createDate
    this.Editing = false;
  }
}
