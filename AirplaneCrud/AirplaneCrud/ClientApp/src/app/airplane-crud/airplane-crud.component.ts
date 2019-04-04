import { Component } from '@angular/core';
import { AirplaneModel } from './airplane-model';
import { HttpClient } from '@angular/common/http';

import { Event } from '@angular/router';

@Component({
  selector: 'airplane-crud-component',
  templateUrl: './airplane-crud.component.html',
})
export class AirplaneCrudComponent {
  public Airplanes = Array<AirplaneModel>();

  constructor(private http: HttpClient) {
    let a = new AirplaneModel(null);
    a.Id = "1";
    a.Editing = false;
    a.MaxPassengers = 10;
    a.Model = "123";
    a.CreateDate = "10/10/2019";
    this.Airplanes.push(a);

    let b = new AirplaneModel(null);
    b.Id = "2";
    b.Editing = true;
    b.MaxPassengers = 20;
    b.Model = "321";
    b.CreateDate = "10/10/2019";
    this.Airplanes.push(b);

    this.getProducts();
  };

  newItem() {
    let creatingItem = this.Airplanes.filter(i => !i.Id);
    if (creatingItem.length === 0) {
      let b = new AirplaneModel(null);
      b.Editing = true;
      this.Airplanes.unshift(b)
    }
  }

  edit(id: string) {
    this.Airplanes = this.Airplanes.map(x => {
      if (id == x.Id)
        x.Editing = true;
      return x;
    })
  }

  cancel(index: number) {
    this.Airplanes[index].Editing = false;
    if (!this.Airplanes[index].Id)
      this.Airplanes.splice(index, 1)
  }

  getProducts() {
    fetch("https://localhost:44374/api/airplane/")
      .then(response => response.json())
  }
}
