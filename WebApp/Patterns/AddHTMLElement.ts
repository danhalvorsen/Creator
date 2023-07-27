import { HTMLElement } from "node-html-parser";
import { ICommand } from "./Commands";

export class AddWebElementCommand implements ICommand {
	private element: HTMLElement;

	public setElement(element: HTMLElement): void {
		this.element = element;
	}

	public getElement(): HTMLElement {
		return this.element;
	};

}
