import { HTMLElement } from "node-html-parser";
import { strict as assert } from 'node:assert';
import { ICommand, ICommandHandler } from "../Commands";
import { HandlerAction } from "../TypeAliases";

class AddHTMLElementCommand implements ICommand {
	private element: HTMLElement;
	set Element(element: HTMLElement) {
		this.element = element;
	}

	get Element(): HTMLElement {
		return this.element;
	}
}

class AddWebElementHandler implements ICommandHandler<AddHTMLElementCommand> {
	handle(command: AddHTMLElementCommand, action: HandlerAction): HTMLElement {
		console.log("AddWebElementHandler");
		assert(action, "action argument is missing");

		console.log("All good");
		return null;
	}
}
