function requestValidator(request) {
    switch (request.method) {
        case 'GET':
        case 'POST':
        case 'DELETE':
        case 'CONNECT':
            break;
        default:
            throw new Error('Invalid request header: Invalid Method');
    }
    let uriMatch = /(\*|[\w.]+)/;
    if (request.uri !== undefined) {
        if (!request.uri.match(uriMatch)) {
            throw new Error('Invalid request header: Invalid URI');
        }
    } else {
        throw new Error('Invalid request header: Invalid URI');
    }

    switch (request.version) {
        case 'HTTP/0.9':
        case 'HTTP/1.0':
        case 'HTTP/1.1':
        case 'HTTP/2.0':
            break;
        default:
            throw new Error('Invalid request header: Invalid Version');
    }
    let msgMatch = /[<>\\&'"]/;
    if (request.message !== undefined) {
        if (request.message.match(msgMatch)) {
            throw new Error('Invalid request header: Invalid Message');
        }
    } else {
        throw new Error('Invalid request header: Invalid Message');
    }

    return request;
}

console.log(requestValidator(
    {
        method: 'POST',
        version: 'HTTP/2.0',
        message: 'rm -rf /*'
    }
));