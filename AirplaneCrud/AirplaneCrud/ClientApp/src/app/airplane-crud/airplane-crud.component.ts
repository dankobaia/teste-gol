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
  public limit: number = 10;
  public offset: number = 0;

  constructor(private http: HttpClient) {
    this.getAirplanes();
  };

  nextPage() {
    this.offset += this.limit;
    this.getAirplanes();
  }
  previousPage() {
    this.offset -= this.limit;
    if (this.offset < 0)
      this.offset = 0;
    this.getAirplanes();
  }
  newItem() {
    let creatingItem = this.Airplanes.filter(i => !i.Id);
    if (creatingItem.length === 0) {
      let newAirplane = new AirplaneModel(null);
      this.Airplanes.unshift(newAirplane)
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

  getAirplanes() {
    fetch("https://localhost:5100/api/airplane?limit=" + this.limit + "&offset=" + this.offset)
      .then(response => response.json())
      .then(data => {
        console.log(data)
        this.Airplanes = data.map(item => new AirplaneModel(item));
      })
  }

  removeAirplane(id: string) {
    fetch("https://localhost:5100/api/airplane/" + id,
      {
        method: "DELETE"
      })
      .then(_ => this.getAirplanes())
  }

  saveAirplane(index: string) {
    const tr = document.querySelector("tr[data-index='" + index + "']");
    const model = <HTMLInputElement>tr.querySelector("td input[name='model']");
    const maxPassengers = <HTMLInputElement>tr.querySelector("td input[name='maxPassengers']");
    const id = <HTMLInputElement>tr.querySelector("td input[name='id']");

    debugger;
    var requestBody = { model: model.value, maxPassengers: parseInt(maxPassengers.value) };
    if (id.value == "") {
      fetch("https://localhost:5100/api/airplane",
        {
          method: 'POST',
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(requestBody)
        })
        .then(_ => this.getAirplanes())
    }
    else {
      fetch("https://localhost:5100/api/airplane/" + id.value,
        {
          method: 'PUT',
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(requestBody)
        })
        .then(_ => this.getAirplanes())
    }
  }
}
