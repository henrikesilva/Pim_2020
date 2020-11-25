import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertService } from 'src/app/shared/services/alert.service';
import { CreateUsuarioService } from '../create-usuario/services/create-usuario.service';
import { UpdateUsuarioService } from './services/update-usuario.service';

@Component({
  selector: 'app-update-usuario',
  templateUrl: './update-usuario.component.html',
  styleUrls: ['./update-usuario.component.css']
})
export class UpdateUsuarioComponent implements OnInit {

  perfis: any;
  funcionarios: any;
  clientes: any;

  perfil: any;
  usuario: any;

  constructor(
    private updateUsuarioService: UpdateUsuarioService,
    private usuarioService: CreateUsuarioService,
    private alertService: AlertService,
    private router: Router,
    private route: ActivatedRoute
  ) { 
    usuarioService.listarPerfil().subscribe(perfil => this.perfis = perfil);
    usuarioService.listarPerfil().subscribe(funcionario => this.funcionarios = funcionario);
    usuarioService.listarPerfil().subscribe(cliente => this.clientes = cliente);
  }

  ngOnInit(): void {
    let id = +this.route.snapshot.paramMap.get('id');

    this.updateUsuarioService.readById(id).subscribe(usuario => {
      this.usuario = usuario;
    });
  }

  buscarPerfil(nome) {
    var perfil = this.perfis.filter(function(obj){
      return obj.peR_STR_NOME === nome;
    });

    for(const p of perfil){
      this.usuario.PER_INT_ID = p.peR_INT_ID;
    }
  }

  atualizarUsuario() {
    this.updateUsuarioService.update(this.usuario).subscribe(() => {
      this.alertService.showMessage('Usuário atualizado com sucesso');
      this.router.navigate(['/home-usuario']);
    })
  }

  cancelar() {
    this.alertService.showMessage("Solicitação cancelada");
    this.router.navigate(['/home-usuario']);
  }

}
