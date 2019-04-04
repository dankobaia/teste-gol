export class AirplaneModel {
  public Id: string;
  public Model: string;
  public MaxPassengers: number;
  public CreateDate: string;
  public Editing: boolean;

  constructor(item: any) {
    //this.Id = item.Id;
    //this.Model = item.Model;
    //this.MaximumPassengers = item.MaximumPassengers;
    //this.CreateDate = item.IdCreateDate
    this.Editing = false;
  }
}
