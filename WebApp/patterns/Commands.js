"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AddContentHeaderCommand = exports.BlaCommandHandler = exports.BlaCommand = exports.FooCommandHandler = exports.AbstractCommandHandler = exports.FooCommand = exports.abstractCommand = void 0;
class abstractCommand {
}
exports.abstractCommand = abstractCommand;
class FooCommand extends abstractCommand {
    FooCommand() {
        console.log("FooCommand");
    }
}
exports.FooCommand = FooCommand;
class AbstractCommandHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command, action) {
        throw new Error("Method not implemented.");
    }
}
exports.AbstractCommandHandler = AbstractCommandHandler;
class FooCommandHandler extends AbstractCommandHandler {
    handle(command) {
        throw new Error("Method not implemented.");
    }
}
exports.FooCommandHandler = FooCommandHandler;
class BlaCommand {
}
exports.BlaCommand = BlaCommand;
class BlaCommandHandler {
    constructor(motherHandler) {
    }
    handle(command) {
        throw new Error("Method not implemented.");
    }
}
exports.BlaCommandHandler = BlaCommandHandler;
class AddContentHeaderCommand {
    constructor(response, contentType) {
        this.serverResponse = response;
        this.contentType = contentType;
    }
}
exports.AddContentHeaderCommand = AddContentHeaderCommand;
class SetContentHeaderHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command) {
        console.log('SetContentHeaderHandler');
        console.log('SetContentHeaderHandler-Start');
        if (this.next != null) {
            this.next.handle(command);
        }
        command.serverResponse.writeHead(200, { 'Content-Type': `${command.contentType}` });
        console.log('SetContentHeaderHandler-Finished');
    }
}
exports.default = SetContentHeaderHandler;
//# sourceMappingURL=Commands.js.map