import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertService } from 'src/app/shared/services/alert.service';
import { CreateClienteService } from './services/create-cliente.service';

@Component({
  selector: 'app-create-cliente',
  templateUrl: './create-cliente.component.html',
  styleUrls: ['./create-cliente.component.css']
})
export class CreateClienteComponent implements OnInit {

  cliente: any = {};

  enderecos: any;

  constructor(
    private createClienteService: CreateClienteService,
    private alertService: AlertService,
    private router: Router
  ) { 
    createClienteService.listarEndereco().subscribe(e => this.enderecos = e);
  }

  ngOnInit(): void {
  }


  buscarEndereco(nome){
    var endereco = this.enderecos.filter(function(obj){
      return obj.enD_STR_RUA === nome;
    });

    for(const e of endereco){
      this.cliente.END_INT_ID = e.enD_INT_ID;
    }
  }

  criar(createForm){
    if(!createForm.form.valid){
      this.alertService.showMessage('Por gentileza informe todos os campos');
    }
    else{
      this.createClienteService.cadastrar(this.cliente).subscribe(
        cadastro => {
          this.cliente = cadastro;
          this.alertService.showMessage('Cliente Cadastrado com sucesso');
          this.router.navigate(['/home-cliente']);
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
    this.router.navigate(['/home-cliente'])
  }

}
