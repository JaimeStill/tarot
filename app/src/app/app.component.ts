import { Component, OnInit } from '@angular/core';
import { TarotCard } from './models';
import { TarotApi } from './services';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  providers: [TarotApi]
})
export class AppComponent implements OnInit {
  deck: TarotCard[] = new Array<TarotCard>();

  constructor(
    private tarot: TarotApi
  ) { }
  
  async ngOnInit(): Promise<void> {
    this.deck = await this.tarot.get();
  }
}
