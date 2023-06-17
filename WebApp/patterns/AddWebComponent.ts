import { ICommand, ICommandHandler } from "./Commands";
import IHttpStreamsContainer from "./IHttpStreamsContainer";

/*
How To Server-Side Render A Web Component
https://itnext.io/how-to-server-side-render-a-web-component-770cd25efb6f#:~:text=Server%2Dside%20rendering%20means%20the,the%20rest%20in%20the%20browser.
*/

let markdown: string = `
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
        <slot></slot>
      </template>
      <p>This is a light DOM</p>
    </my-element>
`;

export class AddWebComponentCommand implements ICommand {
    definition: string;
	constructor(definition: string) {
		this.definition = definition;
	}
}

export default class CommandAggregation implements ICommand {
	readonly commands: Array<ICommand>;
	constructor(commands: Array<ICommand>) {
		this.commands = commands;
	}
}

export class AddWebComponentCommandHandler implements ICommandHandler<CommandAggregation> {
	next: ICommandHandler<ICommand>;
	container: IHttpStreamsContainer;
	constructor(next: ICommandHandler<ICommand>, container: IHttpStreamsContainer) {
		this.next = next;
		this.container = container;
	}

	handle(command: CommandAggregation): void {
		console.log('CommandAggregation')
		console.log('AddWebComponentCommandHandler-Start')
		if (this.next != null) {
			this.next.handle(command);
		}

		let c: ICommand = command.commands.find(cmd => cmd == AddWebComponentCommand);
		let cc = c as AddWebComponentCommand;
		if (cc == null) {
			throw "Cast exception problems casting one or many command from the aggregate";
		}

		this.container.response.write(cc.definition);
		console.log('AddWebComponentCommandHandler-Finished')
	}

}
