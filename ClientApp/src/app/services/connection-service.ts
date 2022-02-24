import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ConnectionModel } from "../models/connection-model";

@Injectable()

export class ConnectionService{
    constructor(
        private http: HttpClient
    ){}
    
    public postConnection(connection: ConnectionModel): Observable<ConnectionModel> {
        return this.http.post<ConnectionModel>('/connections/postconnection', connection);
    }
}