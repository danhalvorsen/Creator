"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AddContentHandler = exports.AddContentCommand = void 0;
class AddContentCommand {
    constructor(response, content) {
        this.content = content;
        this.response = response;
    }
    GetContent() {
        return this.content;
    }
}
exports.AddContentCommand = AddContentCommand;
class AddContentHandler {
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
exports.AddContentHandler = AddContentHandler;
//# sourceMappingURL=SetContent.js.map