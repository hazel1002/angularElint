import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core'
import { NgbPagination } from '@ng-bootstrap/ng-bootstrap'
import { NgIf } from '@angular/common'

@Component({
  selector: 'ngx-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.scss'],
  standalone: true,
  imports: [NgIf, NgbPagination],
})
export class PaginationComponent implements OnInit {
  @Output() PageChange = new EventEmitter()
  @Input() Page: number | undefined
  @Input() PageSize: number = 0
  @Input() CollectionSize: number = 0

  constructor() {}

  ngOnInit(): void {}

  pageChange() {
    this.PageChange.emit(this.Page)
  }
}
