import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { BlogersService } from 'src/app/core/blogers.service';
import { IAllBlogerOutputModel } from 'src/app/core/models/Bloger.interface';

@Component({
  selector: 'app-table-bloger',
  templateUrl: './table-bloger.component.html',
  styleUrls: ['./table-bloger.component.sass']
})
export class TableBlogerComponent implements OnInit {

  constructor(private readonly service:BlogersService){}  
  dataSource!: MatTableDataSource<IAllBlogerOutputModel>;
  ngOnInit(): void {
    this.service.GetAllBlogers().subscribe(resp =>{
      this.dataSource = new MatTableDataSource<IAllBlogerOutputModel>(resp);
    })
  }
  displayedColumns: string[] = ['name', 'website', 'picture'];
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  addBlogger() {
    
  }
}
