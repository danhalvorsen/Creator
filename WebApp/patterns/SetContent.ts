import { ServerResponse } from "http";
import { ICommand, ICommandHandler } from "./Commands";

export class AddContentCommand implements ICommand {

	readonly content: string;
	public response: ServerResponse;
	constructor(response: ServerResponse, content: string) {
		this.content = content;
		this.response = response;
	};

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
