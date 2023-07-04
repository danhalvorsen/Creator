"use strict";
//https://gist.github.com/bakerface/492c631c6aa23e915bde9243252b52f4
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.sleep = exports.None = exports.CancellationTokenSource = exports.CancellationError = void 0;
class CancellationError extends Error {
    constructor() {
        super(...arguments);
        this.name = "CancellationError";
        this.message = "The operation was cancelled";
    }
}
exports.CancellationError = CancellationError;
class CancellationTokenSource {
    constructor() {
        this._subscribers = [];
    }
    subscribe(subscriber) {
        if (this._cancellation) {
            subscriber(this._cancellation);
        }
        else {
            this._subscribers.push(subscriber);
        }
        return () => {
            this._subscribers = this._subscribers.filter(s => s !== subscriber);
        };
    }
    cancel(err = new CancellationError()) {
        this._cancellation = err;
        this._subscribers.splice(0).forEach(subscriber => subscriber(err));
    }
}
exports.CancellationTokenSource = CancellationTokenSource;
exports.None = new CancellationTokenSource();
function sleep(ms, token = exports.None) {
    return new Promise((resolve, reject) => {
        const handle = setTimeout(() => {
            unsubscribe();
            resolve();
        }, ms);
        const unsubscribe = token.subscribe(err => {
            clearTimeout(handle);
            reject(err);
        });
    });
}
exports.sleep = sleep;
function main(token = exports.None) {
    return __awaiter(this, void 0, void 0, function* () {
        yield sleep(6e4, token);
    });
}
const token = new CancellationTokenSource();
main(token);
setTimeout(() => token.cancel(), 1e3);
//# sourceMappingURL=CancellationToken.js.map