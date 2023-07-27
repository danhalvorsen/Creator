import { read } from "fs";
import { ICommand, ICommandHandler } from "./Commands";
import IHttpStreamsContainer from "./IHttpStreamsContainer";
const fs = require('fs');
/*
How To Server-Side Render A Web Component
https://itnext.io/how-to-server-side-render-a-web-component-770cd25efb6f#:~:text=Server%2Dside%20rendering%20means%20the,the%20rest%20in%20the%20browser.
*/

export class AddWebComponentCommand implements ICommand {
	public WCdefinition = '';
	constructor() {
		const webComponent =
			this.WCdefinition = `
					<my-element>
						<template shadowrootmode="open">
							<style>
								h1 {
									color: red;
								}
								::slotted(p) {
									color: green;
								}
							</style>
							<h1>Declarative Shadow DOM</h1>
								<button id="b1">Press me slowly</button>
							<slot></slot>
						</template>
						<p>This is a light DOM</p>
					</my-element>`;
	}

	private readFile(file: string): string {
		
		fs.readFile('C:/Users/danha/source/repos/Creator/WebApp/Patterns/Page/WebComponent.xml', (error, data) => {
			if (error) {
				console.log(error);
				return "";
			}
			console.log(data);
			return data;	
		});
		return "";
	}

}
export default class AggregationOfCommands implements ICommand {
	readonly aggregate: Array<ICommand>;
	constructor(commands: Array<ICommand>) {
		this.aggregate = new Array<ICommand>();
		this.aggregate = commands;
	}
}

export class AddWebComponentCommandHandler implements ICommandHandler<AggregationOfCommands> {
	next: ICommandHandler<ICommand>;
	container: IHttpStreamsContainer;
	constructor(next: ICommandHandler<ICommand>, container: IHttpStreamsContainer) {
		this.next = next;
		this.container = container;
	}

	handle(aggregate: AggregationOfCommands): void {
		console.log('CommandAggregation')
		console.log('CommandAggregation-Start')
		if (this.next != null) {
			this.next.handle(aggregate);
		}

		const command = TryResolveCommandFrom(aggregate);

		this.container.response.write(command.WCdefinition);
		console.log('CommandAggregation-Finished')
	}
}

function TryResolveCommandFrom(command: AggregationOfCommands): AddWebComponentCommand {
	const addWCCmd: ICommand = command.aggregate.find(i => i instanceof AddWebComponentCommand);
	if (addWCCmd == null) {
		throw "The wanted command is not present in the aggregate";
	}

	const castedwantedCommand = addWCCmd as AddWebComponentCommand;
	if (castedwantedCommand == null)
		throw "Casting promising object to wanted command failed!";
	return castedwantedCommand;
}
