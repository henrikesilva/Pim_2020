import { TestBed } from '@angular/core/testing';

import { HomeClienteService } from './home-cliente.service';

describe('HomeClienteService', () => {
  let service: HomeClienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HomeClienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
