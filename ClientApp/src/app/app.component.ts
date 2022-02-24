import { Component, OnInit } from '@angular/core';
import { ConnectionModel } from './models/connection-model';
import { ConnectionService } from './services/connection-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers:[ConnectionService]
})
export class AppComponent {
  constructor(
    private connections: ConnectionService
  ){

  }
  title = 'app';
  public connection = null;

  ngOnInit(): void {

    this.connection = new ConnectionModel();

    this.connections.postConnection(this.connection).subscribe();
    
  }
}
