import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertService } from 'src/app/shared/services/alert.service';
import { CreateClienteService } from '../create-cliente/services/create-cliente.service';
import { UpdateClienteService } from './services/update-cliente.service';

@Component({
  selector: 'app-update-cliente',
  templateUrl: './update-cliente.component.html',
  styleUrls: ['./update-cliente.component.css']
})
export class UpdateClienteComponent implements OnInit {

  enderecos: any;

  cliente: any;

  constructor(
    private http: HttpClient,
    private updateClienteService: UpdateClienteService,
    private clienteService: CreateClienteService,
    private alertService: AlertService,
    private route: ActivatedRoute,
    private router: Router
  ) { 
    clienteService.listarEndereco().subscribe(e => this.enderecos = e);
  }

  ngOnInit(): void {
    let id = +this.route.snapshot.paramMap.get('id');

    this.updateClienteService.readById(id).subscribe(cliente => {
      this.cliente = cliente;
    });
  }

  buscarEndereco(nome) {
    var endereco = this.enderecos.filter(function(obj){
      return obj.enD_STR_RUA === nome;
    });

    for(const e of endereco){
      this.cliente.END_INT_ID = e.enD_INT_ID;
    }
  }

  atualizarCliente() {
    this.updateClienteService.update(this.cliente).subscribe(() => {
      this.alertService.showMessage('Cliente atualizado com sucesso');
      this.router.navigate(['/home-cliente']);
    })
  }

  cancelar() {
    this.alertService.showMessage("Solicitação cancelada");
    this.router.navigate(['/home-cliente']);
  }
}
