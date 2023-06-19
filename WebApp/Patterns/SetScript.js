"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SetScriptHandler = exports.SetScriptCommand = void 0;
var fs = require('fs');
const parse = require('node-html-parser').parse;
class SetScriptCommand {
    constructor(response, file, scriptRef) {
        this.response = response;
        this.file = file;
        this.scriptRef = scriptRef;
    }
    ;
}
exports.SetScriptCommand = SetScriptCommand;
class SetScriptHandler {
    constructor(next) {
        this.next = next;
    }
    handle(command) {
        console.log('SetHeaderHandler');
        console.log('SetHeaderHandler-Start');
        if (this.next != null) {
            this.next.handle(command);
        }
        fs.readFile(command.file, (err, html) => {
            const root = parse(html);
            const head = root.querySelector('head');
            if (head != null) {
                head.set_content('<script type="module" src = "https://cdn.jsdelivr.net/npm/@microsoft/fast-components/dist/fast-components.min.js" > </script>');
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