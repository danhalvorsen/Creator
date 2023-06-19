import "reflect-metadata";
import { inject, container } from "tsyringe";
import http = require('http');
import { IncomingMessage, ServerResponse } from "http";
import SetContentHeaderHandler, { AddContentHeaderCommand, BlaCommandHandler, FooCommandHandler, ICommand } from './patterns/Commands';
import IHttpStreamsContainer, { HttpStreamsContainer } from './patterns/IHttpStreamsContainer';
import { AddContentCommand, AddContentHandler } from './patterns/SetContent';
import AggregationOfCommands, { AddWebComponentCommand, AddWebComponentCommandHandler } from "./patterns/AddWebComponent";
import { SetScriptCommand, SetScriptHandler } from "./Patterns/SetScript";

const webPort = process.env.port || 1337
const apiport = process.env.apiport || 1338
const webSocket = process.env.websocket || 1340

container.register("IHttpStreamsContainer", {
	useClass:	HttpStreamsContainer
});

let setContentCommandHandler = new AddContentHandler(null);
let setContentTypeHandler = new SetContentHeaderHandler(null);

http.createServer(function (req, res) {
	let setScriptCommand = new SetScriptCommand(
		res,
		'C:/Users/danha/source/repos/Creator/WebApp/index.html',
		'<script type="module" src = "https://cdn.jsdelivr.net/npm/@microsoft/fast-components/dist/fast-components.min.js" > </script>')
	let httpHelper: IHttpStreamsContainer = new HttpStreamsContainer(req, res);	
	let setContentTypeCommand = new AddContentHeaderCommand(res, 'text/html');
	let setContentCommand = new AddContentCommand(res, '<h1>Hello World</h1>\n')

	let setScriptCommandHandler = new SetScriptHandler(null);

	let addWebComponentHandler = new AddWebComponentCommandHandler(null, httpHelper);

	setScriptCommandHandler.handle(setScriptCommand);
	setContentTypeHandler.handle(setContentTypeCommand)
	setContentCommandHandler.handle(setContentCommand);
	let addWebComponent = new AddWebComponentCommand();
	let commands = new Array<ICommand>();
	commands.push(addWebComponent);
	let aggregateOfCommands = new AggregationOfCommands(commands);
	addWebComponentHandler.handle(aggregateOfCommands);
	res.end('<h3>END</h3>');
}).listen(webPort);

