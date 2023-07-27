"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const node_assert_1 = require("node:assert");
class AddHTMLElementCommand {
    set Element(element) {
        this.element = element;
    }
    get Element() {
        return this.element;
    }
}
class AddWebElementHandler {
    handle(command, action) {
        console.log("AddWebElementHandler");
        (0, node_assert_1.strict)(action, "action argument is missing");
        console.log("All good");
        return null;
    }
}
//# sourceMappingURL=AddHTMLElementCommand.js.map