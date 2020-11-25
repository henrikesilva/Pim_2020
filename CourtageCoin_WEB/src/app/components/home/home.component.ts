import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/shared/services/auth.service';
import { HomeService } from 'src/app/shared/services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  session: any;
  usuarios: any;
  usuarioID: any;
  carteira: any;

  constructor(
    private authService: AuthService,
    private usuarioService: HomeService
  ) { 
    if(authService.currentUser){
      this.session = this.upperCase(window.localStorage.getItem('user'));
    }
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

    this.usuarioService.valorCarteira(this.usuarioID).subscribe(carteira => this.carteira = carteira);
  }

  upperCase(user){
    return user?.toUpperCase();
  }



}
