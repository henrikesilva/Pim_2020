import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cliente } from 'src/app/shared/models/Cliente.model';
import { Funcionario } from 'src/app/shared/models/Funcionario.model';
import { Perfil } from 'src/app/shared/models/Perfil.model';
import { AlertService } from 'src/app/shared/services/alert.service';
import { CreateUsuarioService } from './services/create-usuario.service';

@Component({
  selector: 'app-create-usuario',
  templateUrl: './create-usuario.component.html',
  styleUrls: ['./create-usuario.component.css']
})
export class CreateUsuarioComponent {

  usuario: any = {};
  
  perfis: any;
  funcionarios: any;
  clientes: any;

  data = new Date();
  anoAtual = '';
  diaAtual = '';
  mesAtual = '';
  dataAtual: any;

  constructor(
    private usuarioService: CreateUsuarioService,
    private alertService: AlertService,
    private router: Router
  ) {
    usuarioService.listarPerfil().subscribe(p => this.perfis = p);
    usuarioService.listarFuncionario().subscribe(f => this.funcionarios = f);
    usuarioService.listarCliente().subscribe(c => this.clientes = c);

    this.anoAtual = formatDate(this.data, 'yyyy', 'en-US', '+0100');
    this.mesAtual = formatDate(this.data, 'MM', 'en-US', '+0100');
    this.diaAtual = formatDate(this.data, 'dd', 'en-US', '+0100');
    this.dataAtual = this.anoAtual + '-' + this.mesAtual + '-' + this.diaAtual;
  }

  
  buscarPerfil(nome) {
    var perfil = this.perfis.filter(function(obj){
      return obj.peR_STR_NOME === nome;
    });

    for(const p of perfil){
      this.usuario.PER_INT_ID = p.peR_INT_ID;
    }
  }

  buscarFuncionario(nome) {
    var funcionario = this.funcionarios.filter(function(obj){
      return obj.fuN_STR_NOME === nome;
    });

    for(const f of funcionario){
      this.usuario.FUN_INT_ID = f.fuN_INT_ID;
    }
  }

  buscarCliente(nome) {
    var cliente = this.clientes.filter(function(obj){
      return obj.clI_STR_NOME === nome;
    });

    for(const c of cliente){
      this.usuario.CLI_INT_ID = c.clI_INT_ID;
    }
  }



  criar(createForm){
    if(!createForm.form.valid){
      this.alertService.showMessage('Por gentileza informe todos os campos');
    }
    else{
      this.usuario.USU_DATA_CADASTRO = this.dataAtual;
      this.usuarioService.cadastrar(this.usuario).subscribe(
        cadastro => {
          this.usuario = cadastro;
          this.alertService.showMessage('Usuario Cadastrado com sucesso');
          this.router.navigate(['/home-usuario']);
        },
        e => {
          this.alertService.showMessage('Ocorreu um erro na sua solicitação, ' +
                      'por gentileza entre em contato com o desenvolvedor do sistema');
        }
      )
    }
  }

  cancelar() {
    this.alertService.showMessage("Solicitação cancelada");
    this.router.navigate(['/home-usuario'])
  }
}
