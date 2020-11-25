import { formatDate } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  data = new Date();
  anoAtual = '';

  constructor() {
    this.anoAtual = formatDate(this.data, 'yyyy', 'en-US', '+0300');
  }

  ngOnInit(): void {
  }

}
