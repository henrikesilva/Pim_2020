import { TestBed } from '@angular/core/testing';

import { CreateClienteService } from './create-cliente.service';

describe('CreateClienteService', () => {
  let service: CreateClienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CreateClienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
