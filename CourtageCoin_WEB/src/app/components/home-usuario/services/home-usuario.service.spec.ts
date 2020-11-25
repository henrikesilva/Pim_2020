import { TestBed } from '@angular/core/testing';

import { HomeUsuarioService } from './home-usuario.service';

describe('HomeUsuarioService', () => {
  let service: HomeUsuarioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HomeUsuarioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
