import "reflect-metadata";
import { container } from "tsyringe";
import AggregationOfCommands, { AddWebComponentCommand, AddWebComponentCommandHandler } from "./patterns/AddWebComponent";
import SetContentHeaderHandler, { AddContentHeaderCommand, ICommand } from './patterns/Commands';
import { scriptFastUI } from "./Patterns/Constants";
import IHttpStreamsContainer, { HttpStreamsContainer } from './patterns/IHttpStreamsContainer';
import { AddContentCommand, AddContentHandler } from './patterns/SetContent';
import { SetScriptCommand, SetScriptHandler } from "./Patterns/SetScript";
import http = require('http');

const webPort = process.env.port || 1337
const apiport = process.env.apiport || 1338
const webSocket = process.env.websocket || 1340

container.register("IHttpStreamsContainer", {
	useClass:	HttpStreamsContainer
});

const setContentCommandHandler = new AddContentHandler(null);
const setContentTypeHandler = new SetContentHeaderHandler(null);

http.createServer(function (req, res) {
	const setScriptCommand = new SetScriptCommand(
		res,
		'C:/Users/danha/source/repos/Creator/WebApp/index.html',
		scriptFastUI);

	const httpHelper: IHttpStreamsContainer = new HttpStreamsContainer(req, res);	
	const setContentTypeCommand = new AddContentHeaderCommand(res, 'text/html');
	const setContentCommand = new AddContentCommand(res, '<h1>Hello World</h1>\n')

	const setScriptCommandHandler = new SetScriptHandler(null);

	const addWebComponentHandler = new AddWebComponentCommandHandler(null, httpHelper);

	setScriptCommandHandler.handle(setScriptCommand);
	setContentTypeHandler.handle(setContentTypeCommand)
	setContentCommandHandler.handle(setContentCommand);
	const addWebComponent = new AddWebComponentCommand();
	const commands = new Array<ICommand>();
	commands.push(addWebComponent);
	const aggregateOfCommands = new AggregationOfCommands(commands);
	addWebComponentHandler.handle(aggregateOfCommands);
	res.end('<h3>END</h3>');
}).listen(webPort);

