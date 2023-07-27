import http = require('http'); 
import { ICommand, ICommandHandler } from "./Commands";
import fs = require('fs');

import { parse } from 'node-html-parser';
import { HandlerAction } from "./TypeAliases";
import { ServerResponse } from 'http';

export class SetScriptCommand implements ICommand {

	readonly scriptRef: string;
	public response: ServerResponse;
	public file: string
	constructor(response: http.ServerResponse, file: string, scriptRef: string) {
		this.response = response;
		this.file = file;
		this.scriptRef = scriptRef;

	}
}

export class SetScriptHandler implements ICommandHandler<SetScriptCommand> {
	next: ICommandHandler<ICommand>;

	constructor(next: ICommandHandler<ICommand>) {
		this.next = next;
	}

	handle(command: SetScriptCommand, action?: HandlerAction): void {
		console.log('SetHeaderHandler')
		console.log('SetHeaderHandler-Start')
		if (this.next != null) {
			this.next.handle(command);
		}
		fs.readFile(command.file, (err, html) => {
			const root = parse(html.toString());
			const head = root.querySelector('head');
			if (head != null) {
				const script = head.querySelector('script');
				console.log('FYI: Element head already have a script tag');

				head.set_content(command.scriptRef);
				console.log(root.toString());
				fs.writeFile(command.file, root.toString(), (err) => {
					if (err) {
						console.log(err);
					} else {
						console.log(`${command.file} has been updated!`);
					}
				});

				console.log('SetHeaderHandler-Finished')
			}
		});
	}
}
