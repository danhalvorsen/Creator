"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AddWebComponentCommandHandler = exports.AddWebComponentCommand = void 0;
const fs = require('fs');
/*
How To Server-Side Render A Web Component
https://itnext.io/how-to-server-side-render-a-web-component-770cd25efb6f#:~:text=Server%2Dside%20rendering%20means%20the,the%20rest%20in%20the%20browser.
*/
class AddWebComponentCommand {
    constructor() {
        this.WCdefinition = '';
        let fileContent = this.WCdefinition = `
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
					</my-element>`;
    }
    readFile(file) {
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
exports.AddWebComponentCommand = AddWebComponentCommand;
class AggregationOfCommands {
    constructor(commands) {
        this.aggregate = new Array();
        this.aggregate = commands;
    }
}
exports.default = AggregationOfCommands;
class AddWebComponentCommandHandler {
    constructor(next, container) {
        this.next = next;
        this.container = container;
    }
    handle(aggregate) {
        console.log('CommandAggregation');
        console.log('CommandAggregation-Start');
        if (this.next != null) {
            this.next.handle(aggregate);
        }
        let command = TryResolveCommandFrom(aggregate);
        this.container.response.write(command.WCdefinition);
        console.log('CommandAggregation-Finished');
    }
}
exports.AddWebComponentCommandHandler = AddWebComponentCommandHandler;
function TryResolveCommandFrom(command) {
    let addWCCmd = command.aggregate.find(i => i instanceof AddWebComponentCommand);
    if (addWCCmd == null) {
        throw "The wanted command is not present in the aggregate";
    }
    let castedwantedCommand = addWCCmd;
    if (castedwantedCommand == null)
        throw "Casting promising object to wanted command failed!";
    return castedwantedCommand;
}
//# sourceMappingURL=AddWebComponent.js.map