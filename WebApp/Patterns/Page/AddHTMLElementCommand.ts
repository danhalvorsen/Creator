
import { strict as assert } from 'node:assert';
import { ICommand, ICommandHandler } from "../Commands";
import { HandlerAction } from "../TypeAliases";

export class AddHTMLElementCommand implements ICommand {
	private element: HTMLElement;

	constructor(element: HTMLElement) {
		this.element = element;
	};
	set Element(element: HTMLElement) {
		this.element = element;
	}

	get Element(): HTMLElement {
		return this.element;
	}
}

export class AddWebElementHandler implements ICommandHandler<AddHTMLElementCommand> {
	handle(command: AddHTMLElementCommand, action: HandlerAction): HTMLElement {
		console.log("AddWebElementHandler");
		assert(action, "action argument is missing");

		console.log("All good");
		return null;
	}
}
