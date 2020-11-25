import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { HomeClienteService } from './services/home-cliente.service';

@Component({
  selector: 'app-home-cliente',
  templateUrl: './home-cliente.component.html',
  styleUrls: ['./home-cliente.component.css']
})
export class HomeClienteComponent {

  dataSource = new MatTableDataSource<Cliente>(ELEMENT_DATA);
  cliente: any;
  clientes: any[];

  displayedColumns: string[] = ['CLI_INT_ID', 'CLI_STR_NOME', 'CLI_STR_CPF', 'CLI_DATE_NASCIMENTO'];

  
  constructor(
    private clienteService: HomeClienteService,
    private router: Router
    ) {
      clienteService.read().subscribe(clientes => {
        this.clientes = clientes
        
        this.dataSource = new MatTableDataSource(clientes);
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
      });
    }
    
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  
  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue;
  }
}

const ELEMENT_DATA: Cliente[] = [];