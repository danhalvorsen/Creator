import { ServerResponse } from "http";
import { HandlerAction } from "./TypeAliases";

export interface ICommand {
}

export class abstractCommand implements ICommand {
}

export class FooCommand extends abstractCommand {
	FooCommand() {
		console.log("FooCommand")
	}
}

export interface ICommandHandler<T> {
	handle(command: T, action?: HandlerAction): void
}

export abstract class AbstractCommandHandler<T> implements ICommandHandler<T> {
	protected handler: ICommandHandler<T>;
	next: ICommandHandler<T>;

	constructor(next: ICommandHandler<T>) {
		this.next = next;
	}

	handle(command: T, action: HandlerAction): void {
		throw new Error("Method not implemented.");
	}
}

export class FooCommandHandler extends AbstractCommandHandler<FooCommand>{
	handle(command: FooCommand): void {
		throw new Error("Method not implemented.");
	}
}

export class BlaCommand implements ICommand {

}

export class BlaCommandHandler implements ICommandHandler<BlaCommand>
{
	constructor(motherHandler: ICommandHandler<FooCommand>) {

	}

	handle(command: BlaCommand): void {
		throw new Error("Method not implemented.");
	}

	private handler: ICommandHandler<ICommand>;
}

export class AddContentHeaderCommand implements ICommand {
	serverResponse: ServerResponse;
	contentType: string;
	constructor(response: ServerResponse, contentType: string) {
		this.serverResponse = response;
		this.contentType = contentType;
	}
}

export default class SetContentHeaderHandler implements ICommandHandler<AddContentHeaderCommand>{
	next: ICommandHandler<ICommand>;
	constructor(next: ICommandHandler<ICommand>) {
		this.next = next;
	}

	handle(command: AddContentHeaderCommand): void {
		console.log('SetContentHeaderHandler')
		console.log('SetContentHeaderHandler-Start')
		if (this.next != null) {
			this.next.handle(command);
		}

		command.serverResponse.writeHead(200, { 'Content-Type': `${command.contentType}` });
		console.log('SetContentHeaderHandler-Finished')
	}
}

