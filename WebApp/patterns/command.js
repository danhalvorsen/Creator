"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SetContentHandler = exports.SetContentCommand = exports.SetContentHeaderCommand = exports.BlaCommandHandler = exports.BlaCommand = exports.FooCommandHandler = exports.AbstractCommandHandler = exports.FooCommand = exports.abstractCommand = void 0;
class abstractCommand {
}
exports.abstractCommand = abstractCommand;
class FooCommand extends abstractCommand {
    FooCommand() { }
}
exports.FooCommand = FooCommand;
class AbstractCommandHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command) {
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
class SetContentHeaderCommand {
    constructor(response, contentType) {
        this.serverResponse = response;
        this.contentType = contentType;
    }
}
exports.SetContentHeaderCommand = SetContentHeaderCommand;
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
class SetContentCommand {
    constructor(response, content) {
        this.content = content;
        this.response = response;
    }
    ;
    GetContent() {
        return this.content;
    }
}
exports.SetContentCommand = SetContentCommand;
class SetContentHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command) {
        console.log('SetContentHandler');
        console.log('SetContentHandler-Start');
        if (this.next != null) {
            this.next.handle(command);
        }
        command.response.write(command.content);
        console.log('SetContentHandler-Finished');
    }
}
exports.SetContentHandler = SetContentHandler;
//# sourceMappingURL=command.js.map