"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const http = require("http");
const port = process.env.port || 1337;
http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/html' });
    //res.end('Hello World\n');
    res.end('<h1>Hello World</h1>\n');
}).listen(port);
//# sourceMappingURL=server.js.map