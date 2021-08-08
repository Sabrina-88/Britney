import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public shows: any = [];// deixar any = []  serve para o html aceitar evento.lenght, sem [] ele nao aceita
  public showsFiltrados: any = [];
  exibirImagem = false;
  private _filtroLista = '';

  constructor(
    private http: HttpClient) {

  }

  ngOnInit(): void {
    this.getshows();
  }

  public getshows() {
    this.http.get('https://localhost:5001/api/shows').subscribe(
      response => {
        this.shows = response
        this.showsFiltrados = this.shows;
        console.log(response)
      },
      error => console.log(error),
    )
    console.log(this.shows)
  }

  public get filtroLista(): string { //essa funcao retorna um string
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.showsFiltrados = this.filtroLista ? this.filtrarshows(this.filtroLista) : this.shows;
  }

  filtrarshows(filtrarPor: string): any { // essa funcao retorna any
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.shows.filter(
      (evento: { tema: string; local: string; }) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 // se for index diferente de -1 é pq ele existe
        || evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  alterarImagem() {
    this.exibirImagem = !this.exibirImagem;
  }

}
