"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
require("reflect-metadata");
const tsyringe_1 = require("tsyringe");
const AddWebComponent_1 = require("./patterns/AddWebComponent");
const Commands_1 = require("./patterns/Commands");
const Constants_1 = require("./Patterns/Constants");
const IHttpStreamsContainer_1 = require("./patterns/IHttpStreamsContainer");
const SetContent_1 = require("./patterns/SetContent");
const SetScript_1 = require("./Patterns/SetScript");
const http = require("http");
const webPort = process.env.port || 1337;
const apiport = process.env.apiport || 1338;
const webSocket = process.env.websocket || 1340;
tsyringe_1.container.register("IHttpStreamsContainer", {
    useClass: IHttpStreamsContainer_1.HttpStreamsContainer
});
const setContentCommandHandler = new SetContent_1.AddContentHandler(null);
const setContentTypeHandler = new Commands_1.default(null);
http.createServer(function (req, res) {
    const setScriptCommand = new SetScript_1.SetScriptCommand(res, 'C:/Users/danha/source/repos/Creator/WebApp/index.html', Constants_1.scriptFastUI);
    const httpHelper = new IHttpStreamsContainer_1.HttpStreamsContainer(req, res);
    const setContentTypeCommand = new Commands_1.AddContentHeaderCommand(res, 'text/html');
    const setContentCommand = new SetContent_1.AddContentCommand(res, '<h1>Hello World</h1>\n');
    const setScriptCommandHandler = new SetScript_1.SetScriptHandler(null);
    const addWebComponentHandler = new AddWebComponent_1.AddWebComponentCommandHandler(null, httpHelper);
    setScriptCommandHandler.handle(setScriptCommand);
    setContentTypeHandler.handle(setContentTypeCommand);
    setContentCommandHandler.handle(setContentCommand);
    const addWebComponent = new AddWebComponent_1.AddWebComponentCommand();
    const commands = new Array();
    commands.push(addWebComponent);
    const aggregateOfCommands = new AddWebComponent_1.default(commands);
    addWebComponentHandler.handle(aggregateOfCommands);
    res.end('<h3>END</h3>');
}).listen(webPort);
//# sourceMappingURL=server.js.map