import { Component } from '@angular/core';
import { DataService } from 'src/services/data.service';
import { Customers } from '../app/models/customers';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [DataService]
})
export class AppComponent {

  title = 'ANGULAR - TP9';


  customers: Array<Customers> = [];
  cust: Customers;
  elementToEdit: Customers;


  constructor(private dataSvc: DataService) { }



  ngOnInit() {
    this.dataSvc.getAll().subscribe((res) => {
      this.customers = res;
      console.log('Res ', res);

    });
  }

  edit(id: string) {
    this.dataSvc.GetById(id).subscribe(res => {
      this.elementToEdit = res;
    })
  }


  delete(id: number) {
    if (confirm('Esta seguro que quiere eliminar el cliente??')) {
      console.log('id ', id);
      this.dataSvc.Delete(id).subscribe(res => {
        if (res == "OK") {
          window.location.reload()
          alert("Los datos del cliente fueron eliminados correctamente")
        }
      },
        err => {
          alert("Error: No se pudo eliminar el cliente!!")
        });
    }
  }



}

