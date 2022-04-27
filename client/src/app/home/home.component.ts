import { Component, OnInit } from '@angular/core';
import { News } from '../_models/news';
import { NewsService } from '../_services/news.service';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  newsData: News[] = [];
  paramData: News = {newsType : '', newsText: ''};
  typeList = [{value: '', display: 'All'} ,{value: 'Israel', display: 'Israel'},
              {value: 'World', display: 'World'},
              {value: 'Culture', display: 'Culture'}, {value: 'Sports', display: 'Sports'}];

  constructor(private newsService: NewsService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getNewsData();
  }

  getNewsData() {
    this.newsService.getNews(this.paramData).subscribe(result => {
       this.newsData = result;
       },error => {
       console.log(error);
       this.toastr.error('No data found.');
       });
      }
 
}
