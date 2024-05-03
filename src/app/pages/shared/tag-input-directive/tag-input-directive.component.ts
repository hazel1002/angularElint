import { AllowHelper } from './../../../helper/allowHelper';
import { BaseComponent } from './../../base/baseComponent';
import {
  ChangeDetectionStrategy,
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  ViewChild,
} from '@angular/core';
import {
  NbTagComponent,
  NbTagInputAddEvent,
  NbTagModule,
  NbAutocompleteModule,
  NbOptionModule,
} from '@nebular/theme';
import { Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { ShareRequest } from '../../../../model/Request/shareRequest';
import { TagService } from '../../../services/tag.service';
import { FormsModule } from '@angular/forms';
import { NgFor, AsyncPipe } from '@angular/common';

@Component({
  selector: 'ngx-tag-input-directive',
  templateUrl: './tag-input-directive.component.html',
  styleUrls: ['./tag-input-directive.component.scss'],
  standalone: true,
  imports: [
    NbTagModule,
    NgFor,
    NbAutocompleteModule,
    FormsModule,
    NbOptionModule,
    AsyncPipe,
  ],
})
export class TagInputDirectiveComponent
  extends BaseComponent
  implements OnInit
{
  @ViewChild('autoInput') input: any;

  @Input() TagItems = [] as string[];
  @Input() TagId: number | undefined;
  @Input() TagName: string | undefined;
  @Output() OutputTagItems = new EventEmitter();

  options = [] as string[];
  filteredOptions$: Observable<string[]> | undefined;
  isAutocomplete = false;

  request = new ShareRequest();
  tagValue = '';

  constructor(
    private tagService: TagService,
    protected override allow: AllowHelper
  ) {
    super(allow);
  }

  override ngOnInit(): void {}

  // 標籤刪除
  onTagRemove(tagToRemove: NbTagComponent): void {
    this.TagItems = this.TagItems.filter((t) => t !== tagToRemove.text);
    this.OutputTagItems.emit(this.TagItems);
  }
  // 標籤新增
  onTagAdd({ value, input }: NbTagInputAddEvent): void {
    if (value) {
      this.TagItems.push(value);
      this.OutputTagItems.emit(this.TagItems);
    }
    input.nativeElement.value = '';
  }

  onTagAddByFocus() {
    if (!this.isNullOrEmpty(this.tagValue)) {
      this.TagItems.push(this.tagValue);
      this.OutputTagItems.emit(this.TagItems);
      this.tagValue = '';
    }
  }

  private filter(value: string): string[] {
    const filterValue = value.toLowerCase();
    return this.options.filter((optionValue) =>
      optionValue.toLowerCase().includes(filterValue)
    );
  }

  getFilteredOptions(value: string): Observable<string[]> {
    return of(value).pipe(map((filterString) => this.filter(filterString)));
  }

  onAutocompleteChange() {
    if (this.isAutocomplete === false) {
      this.isAutocomplete = true;
      setTimeout(() => {
        this.getAutocomplete();
      }, 1000);
    }
  }

  getAutocomplete() {
    this.request.CTagId = this.TagId;
    this.request.CTagName = this.TagName;
    this.request.CName = this.tagValue;
    this.tagService
      .getAutocompleteByTagValueList(this.request)
      .subscribe((res) => {
        this.options = [...res.Entries!.map((x) => x.CTagValue!)];
        this.filteredOptions$ = this.getFilteredOptions(
          this.input.nativeElement.value
        );
        this.isAutocomplete = false;
      });
  }

  onAutocompleteSelectionChange($event: any) {
    this.filteredOptions$ = this.getFilteredOptions($event);
    this.OutputTagItems.emit(this.TagItems);
  }
}
