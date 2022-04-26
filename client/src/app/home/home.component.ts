import { Component, OnInit } from '@angular/core';
import { News } from '../_models/news';
import { NewsService } from '../_services/news.service';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  newsData: News[] = [];
  paramData: News = {newsType : '', newsText: ''};

  constructor(private newsService: NewsService) { }

  ngOnInit(): void {
    this.getNewsData();
  }

  getNewsData() {
    this.newsService.getNews(this.paramData).subscribe(result => {
       this.newsData = result;
       },error => {
       console.log(error);
       });
      }
 
}
