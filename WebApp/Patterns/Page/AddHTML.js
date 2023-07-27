"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class AddHTMLElementCommand {
    set Element(element) {
        this.element = element;
    }
    ;
    get Element() {
        return this.element;
    }
}
class AddWebElementHandler {
    handle(command) {
        console.log("AddWebElementHandler");
    }
}
//# sourceMappingURL=AddHTML.js.map