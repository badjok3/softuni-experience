let messages = (() => {
    async function getMessages() {
        let messages = await requester.get('appdata', 'messages');
        let currentUserMessages = [];

        for (let msg of messages) {
            if (msg.recipient === sessionStorage.getItem('username')) {
                currentUserMessages.push(msg);
            }
        }

        return currentUserMessages;
    }

    async function getSentMessages() {
        let messages = await requester.get('appdata', 'messages');
        let currentSentMessages = [];

        for (let msg of messages) {
            if (msg.sender.split(' ')[0] === sessionStorage.getItem('username')) {
                currentSentMessages.push(msg);
            }
        }

        return currentSentMessages;
    }

    async function getRecipients() {
        let allUsers = await requester.get('user', '');
        let users = [];
        for (let user of allUsers) {
            if (user.username === sessionStorage.getItem('username')) {
                continue;
            }
            users.push(user);
        }

        return users;
    }

    async function sendMessage(ev) {
        let recipientUsername = $('#msgRecipientUsername option:selected').text().split(' ')[0];
        let message = $('#msgText').val();
        let data = {
            recipient: recipientUsername,
            content: message,
            sender: formatSender(sessionStorage.getItem('name'), sessionStorage.getItem('username')),
            date: formatDate(new Date())
        };

        return requester.post('appdata', 'messages', '', data);
    }

    function formatDate(dateISO8601) {
        let date = new Date(dateISO8601);
        if (Number.isNaN(date.getDate()))
            return '';
        return date.getDate() + '.' + padZeros(date.getMonth() + 1) +
            "." + date.getFullYear() + ' ' + date.getHours() + ':' +
            padZeros(date.getMinutes()) + ':' + padZeros(date.getSeconds());

        function padZeros(num) {
            return ('0' + num).slice(-2);
        }
    }

    function formatSender(name, username) {
        if (!name)
            return username;
        else
            return username + ' (' + name + ')';
    }

    return {
        getMessages,
        getSentMessages,
        getRecipients,
        sendMessage
    }
})();