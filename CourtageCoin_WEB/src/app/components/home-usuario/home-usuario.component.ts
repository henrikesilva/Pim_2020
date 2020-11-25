import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';

import { Usuario } from 'src/app/shared/models/Usuario.model';
import { HomeUsuarioService } from './services/home-usuario.service';

@Component({
  selector: 'app-home-usuario',
  templateUrl: './home-usuario.component.html',
  styleUrls: ['./home-usuario.component.css']
})
export class HomeUsuarioComponent {

  dataSource = new MatTableDataSource<Usuario>(ELEMENT_DATA);

  usuario: any;
  usuarios: any[];

  displayedColumns: string[] = ['USU_INT_ID', 'USU_STR_LOGIN', 'USU_INT_TELEFONE', 'USU_STR_EMAIL'];
  
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private usuarioService: HomeUsuarioService,
    private router: Router
  ) { 
    usuarioService.read().subscribe(usuarios => {
      this.usuarios = usuarios
      
      this.dataSource = new MatTableDataSource(usuarios);
      this.dataSource.sort = this.sort;
      this.dataSource.paginator = this.paginator;
    });

  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue;
  }
}

const ELEMENT_DATA: Usuario[] = [];
