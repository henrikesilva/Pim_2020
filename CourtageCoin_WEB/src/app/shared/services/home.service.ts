import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Carteira } from '../models/Carteira.model';
import { Usuario } from '../models/Usuario.model';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private http: HttpClient) { }

  listarUsuario(){
    return this.http.get<Usuario[]>(`${environment.baseUrl}/usuario`);
  }

  valorCarteira(id){
    return this.http.get<Carteira[]>(`${environment.baseUrl}/carteira/${id}`);
  }
}
