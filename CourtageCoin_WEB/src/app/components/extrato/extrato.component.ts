import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/shared/services/auth.service';
import { HomeService } from 'src/app/shared/services/home.service';
import { ExtratoService } from './services/extrato.service';

@Component({
  selector: 'app-extrato',
  templateUrl: './extrato.component.html',
  styleUrls: ['./extrato.component.css']
})
export class ExtratoComponent implements OnInit {

  usuarioID: any;
  usuarios: any;
  carteira: any;
  valor: any;
  saldo: any;

  constructor(
    private usuarioService: HomeService,
    private extratoService: ExtratoService,
  ) { 
  }

  ngOnInit(): void {
    this.usuarioService.listarUsuario().subscribe(usuario => {
      this.usuarios = usuario
      var user = window.localStorage.getItem('user');
      this.obterUsuarioID(user);
    });
  }

  obterUsuarioID(nome) {
    var usuario = this.usuarios.filter(function(obj){
      return obj.usU_STR_LOGIN === nome;
    });

    for(const u of usuario){
      this.usuarioID = u.usU_INT_ID;
    }

    this.extratoService.readByID(this.usuarioID).subscribe(carteira => this.carteira = carteira);
    this.usuarioService.valorCarteira(this.usuarioID).subscribe(valor => this.valor = valor);
  }

}
