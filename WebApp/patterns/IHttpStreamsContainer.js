"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.HttpStreamsContainer = void 0;
const http_1 = require("http");
const tsyringe_1 = require("tsyringe");
let HttpStreamsContainer = class HttpStreamsContainer {
    constructor(req, res) {
        this.request = req;
        this.response = res;
    }
};
HttpStreamsContainer = __decorate([
    (0, tsyringe_1.injectable)(),
    __metadata("design:paramtypes", [http_1.IncomingMessage, http_1.ServerResponse])
], HttpStreamsContainer);
exports.HttpStreamsContainer = HttpStreamsContainer;
//# sourceMappingURL=IHttpStreamsContainer.js.map