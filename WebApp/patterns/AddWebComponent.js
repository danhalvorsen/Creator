"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AddWebComponentCommandHandler = exports.AddWebComponentCommand = void 0;
/*
How To Server-Side Render A Web Component
https://itnext.io/how-to-server-side-render-a-web-component-770cd25efb6f#:~:text=Server%2Dside%20rendering%20means%20the,the%20rest%20in%20the%20browser.
*/
let markdown = `
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
class AddWebComponentCommand {
    constructor(definition) {
        this.definition = definition;
    }
}
exports.AddWebComponentCommand = AddWebComponentCommand;
class CommandAggregation {
    constructor(commands) {
        this.commands = commands;
    }
}
exports.default = CommandAggregation;
class AddWebComponentCommandHandler {
    constructor(next, container) {
        this.next = next;
        this.container = container;
    }
    handle(command) {
        console.log('CommandAggregation');
        console.log('AddWebComponentCommandHandler-Start');
        if (this.next != null) {
            this.next.handle(command);
        }
        let c = command.commands.find(cmd => cmd == AddWebComponentCommand);
        let cc = c;
        if (cc == null) {
            throw "Cast exception problems casting one or many command from the aggregate";
        }
        this.container.response.write(cc.definition);
        console.log('AddWebComponentCommandHandler-Finished');
    }
}
exports.AddWebComponentCommandHandler = AddWebComponentCommandHandler;
//# sourceMappingURL=AddWebComponent.js.map