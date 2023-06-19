import { ServerResponse } from "http";
import { ICommand, ICommandHandler } from "./Commands";
var fs = require('fs');
const parse = require('node-html-parser').parse;

export class SetScriptCommand implements ICommand {

	readonly scriptRef: string;
	public response: ServerResponse;
	public file: string
	constructor(response: ServerResponse, file: string, scriptRef: string) {
		this.response = response;
		this.file = file;
		this.scriptRef = scriptRef;

	};
}

export class SetScriptHandler implements ICommandHandler<SetScriptCommand> {
	next: ICommandHandler<ICommand>;

	constructor(next: ICommandHandler<ICommand>) {
		this.next = next;
	}

	handle(command: SetScriptCommand): void {
		console.log('SetHeaderHandler')
		console.log('SetHeaderHandler-Start')
		if (this.next != null) {
			this.next.handle(command);
		}
		fs.readFile(command.file, (err, html) => {
			const root = parse(html);
			const head = root.querySelector('head');
			if (head != null) {
				
				head.set_content('<script type="module" src = "https://cdn.jsdelivr.net/npm/@microsoft/fast-components/dist/fast-components.min.js" > </script>');
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
