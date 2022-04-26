import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { News } from '../_models/news';


@Injectable({
  providedIn: 'root'
})
export class NewsService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getNews(sNews: News) {
      const content_ = JSON.stringify(sNews); 
      const httpOptions_ = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };
   
    return this.http.post<News[]>(this.baseUrl + 'news', content_, httpOptions_);
   } 
}
