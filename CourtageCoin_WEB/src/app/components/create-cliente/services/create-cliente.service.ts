import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { Endereco } from 'src/app/shared/models/Endereco.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CreateClienteService {

  constructor(private http: HttpClient) { }

  cadastrar(cliente){
    return this.http.post<Cliente>(`${environment.baseUrl}/cliente`, cliente);
  }

  listarEndereco(){
    return this.http.get<Endereco[]>(`${environment.baseUrl}/endereco`);
  }
}
