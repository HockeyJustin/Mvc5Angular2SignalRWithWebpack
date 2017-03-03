import { NgModule } from '@angular/core'
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routes';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';

import { AboutComponent } from './components/about/about.component';
import { HomeComponent } from './components/home/home.component';


import { ChatComponent } from './components/chat/chat.component';
import { SignalRService } from './services/signalr.service';


@NgModule({
	declarations: [
		AppComponent,
		AboutComponent,
		HomeComponent,
		ChatComponent
	],
	imports: [
		BrowserModule,
		FormsModule,
		ReactiveFormsModule,
		HttpModule,
		RouterModule.forRoot(rootRouterConfig, { useHash: true })
	],
	providers: [
		SignalRService
	],
	bootstrap: [AppComponent]
})
export class AppModule {

}
