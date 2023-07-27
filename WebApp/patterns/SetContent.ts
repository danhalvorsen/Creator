 
import { ServerResponse } from "node:http";
import { ICommand, ICommandHandler } from "./Commands";
import http = require('http');

export class AddContentCommand implements ICommand {

	readonly content: string;
	public response: ServerResponse;
	constructor(response: http.ServerResponse, content: string) {
		this.content = content;
		this.response = response;
	}

	public GetContent(): string {
		return this.content;
	}
}

export class AddContentHandler implements ICommandHandler<AddContentCommand> {
	next: ICommandHandler<ICommand>;

	constructor(next: ICommandHandler<ICommand>) {
		this.next = next;
	}

	handle(command: AddContentCommand): void {
		console.log('SetContentHandler')
		console.log('SetContentHandler-Start')
		if (this.next != null) {
			this.next.handle(command);
		}
		command.response.write(command.content);
		console.log('SetContentHandler-Finished')
	}
}
