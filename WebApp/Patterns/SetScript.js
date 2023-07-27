"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SetScriptHandler = exports.SetScriptCommand = void 0;
const fs = require("fs");
const node_html_parser_1 = require("node-html-parser");
class SetScriptCommand {
    constructor(response, file, scriptRef) {
        this.response = response;
        this.file = file;
        this.scriptRef = scriptRef;
    }
}
exports.SetScriptCommand = SetScriptCommand;
class SetScriptHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command, action) {
        console.log('SetHeaderHandler');
        console.log('SetHeaderHandler-Start');
        if (this.next != null) {
            this.next.handle(command);
        }
        fs.readFile(command.file, (err, html) => {
            const root = (0, node_html_parser_1.parse)(html.toString());
            const head = root.querySelector('head');
            if (head != null) {
                const script = head.querySelector('script');
                console.log('FYI: Element head already have a script tag');
                head.set_content(command.scriptRef);
                console.log(root.toString());
                fs.writeFile(command.file, root.toString(), (err) => {
                    if (err) {
                        console.log(err);
                    }
                    else {
                        console.log(`${command.file} has been updated!`);
                    }
                });
                console.log('SetHeaderHandler-Finished');
            }
        });
    }
}
exports.SetScriptHandler = SetScriptHandler;
//# sourceMappingURL=SetScript.js.map