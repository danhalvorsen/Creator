import { IncomingMessage, ServerResponse } from "http";
import { injectable } from "tsyringe";

export default interface IHttpStreamsContainer {
	readonly request: IncomingMessage;
	response: ServerResponse;
}

@injectable()
export class HttpStreamsContainer implements IHttpStreamsContainer {
	request: IncomingMessage;
	response: ServerResponse;
	constructor(req: IncomingMessage, res: ServerResponse) {
		this.request = req;
		this.response = res;
	}

};
