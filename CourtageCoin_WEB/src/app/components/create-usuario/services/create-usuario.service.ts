import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { Funcionario } from 'src/app/shared/models/Funcionario.model';
import { Perfil } from 'src/app/shared/models/Perfil.model';
import { Usuario } from 'src/app/shared/models/Usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CreateUsuarioService {

  constructor(private http: HttpClient) { }

  cadastrar(usuario){
    return this.http.post<Usuario>(`${environment.baseUrl}/usuario`, usuario);
  }

  listarPerfil(){
    return this.http.get<Perfil[]>(`${environment.baseUrl}/perfil`);
  }
  
  listarFuncionario(){
    return this.http.get<Funcionario[]>(`${environment.baseUrl}/funcionario`);
  }
  
  listarCliente(){
    return this.http.get<Cliente[]>(`${environment.baseUrl}/cliente`);
  }
}
