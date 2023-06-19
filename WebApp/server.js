"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
require("reflect-metadata");
const tsyringe_1 = require("tsyringe");
const http = require("http");
const Commands_1 = require("./patterns/Commands");
const IHttpStreamsContainer_1 = require("./patterns/IHttpStreamsContainer");
const SetContent_1 = require("./patterns/SetContent");
const AddWebComponent_1 = require("./patterns/AddWebComponent");
const SetScript_1 = require("./Patterns/SetScript");
const webPort = process.env.port || 1337;
const apiport = process.env.apiport || 1338;
const webSocket = process.env.websocket || 1340;
tsyringe_1.container.register("IHttpStreamsContainer", {
    useClass: IHttpStreamsContainer_1.HttpStreamsContainer
});
let setContentCommandHandler = new SetContent_1.AddContentHandler(null);
let setContentTypeHandler = new Commands_1.default(null);
http.createServer(function (req, res) {
    let setScriptCommand = new SetScript_1.SetScriptCommand(res, 'C:/Users/danha/source/repos/Creator/WebApp/index.html', '<script type="module" src = "https://cdn.jsdelivr.net/npm/@microsoft/fast-components/dist/fast-components.min.js" > </script>');
    let httpHelper = new IHttpStreamsContainer_1.HttpStreamsContainer(req, res);
    let setContentTypeCommand = new Commands_1.AddContentHeaderCommand(res, 'text/html');
    let setContentCommand = new SetContent_1.AddContentCommand(res, '<h1>Hello World</h1>\n');
    let setScriptCommandHandler = new SetScript_1.SetScriptHandler(null);
    let addWebComponentHandler = new AddWebComponent_1.AddWebComponentCommandHandler(null, httpHelper);
    setScriptCommandHandler.handle(setScriptCommand);
    setContentTypeHandler.handle(setContentTypeCommand);
    setContentCommandHandler.handle(setContentCommand);
    let addWebComponent = new AddWebComponent_1.AddWebComponentCommand();
    let commands = new Array();
    commands.push(addWebComponent);
    let aggregateOfCommands = new AddWebComponent_1.default(commands);
    addWebComponentHandler.handle(aggregateOfCommands);
    res.end('<h3>END</h3>');
}).listen(webPort);
//# sourceMappingURL=server.js.map