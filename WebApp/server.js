"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const http = require("http");
const Commands_1 = require("./patterns/Commands");
const IHttpStreamsContainer_1 = require("./patterns/IHttpStreamsContainer");
const SetContent_1 = require("./patterns/SetContent");
const webPort = process.env.port || 1337;
const apiport = process.env.apiport || 1338;
var fooCommandHandler = new Commands_1.FooCommandHandler(null);
var blaCommandHandler = new Commands_1.BlaCommandHandler(fooCommandHandler);
let setContentCommandHandler = new SetContent_1.AddContentHandler(null);
let setContentTypeHandler = new Commands_1.default(null);
http.createServer(function (req, res) {
    let httpHelper = new IHttpStreamsContainer_1.HttpStreamsContainer(req, res);
    let setContentTypeCommand = new Commands_1.AddContentHeaderCommand(res, 'text/html');
    let setContentCommand = new SetContent_1.AddContentCommand(res, '<h1>Hello World</h1>\n');
    setContentTypeHandler.handle(setContentTypeCommand);
    setContentCommandHandler.handle(setContentCommand);
    res.end('<h3>END</h3>');
}).listen(webPort);
//# sourceMappingURL=server.js.map