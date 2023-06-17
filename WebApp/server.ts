import http = require('http');
import { IncomingMessage, ServerResponse } from "http";
import SetContentHeaderHandler, { AddContentHeaderCommand, BlaCommandHandler, FooCommandHandler } from './patterns/Commands';
import IHttpStreamsContainer, { HttpStreamsContainer } from './patterns/IHttpStreamsContainer';
import { AddContentCommand, AddContentHandler } from './patterns/SetContent';

const webPort = process.env.port || 1337
const apiport = process.env.apiport || 1338

var fooCommandHandler = new FooCommandHandler(null);
var blaCommandHandler = new BlaCommandHandler(fooCommandHandler);

let setContentCommandHandler = new AddContentHandler(null);
let setContentTypeHandler = new SetContentHeaderHandler(null);

http.createServer(function (req, res) {
	let httpHelper: IHttpStreamsContainer = new HttpStreamsContainer(req, res);	
	let setContentTypeCommand = new AddContentHeaderCommand(res, 'text/html');
	let setContentCommand = new AddContentCommand(res, '<h1>Hello World</h1>\n')
	
	setContentTypeHandler.handle(setContentTypeCommand)
	setContentCommandHandler.handle(setContentCommand);
	res.end('<h3>END</h3>');
}).listen(webPort);

