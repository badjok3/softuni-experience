function getTickets(tickets, method) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = +price;
            this.status = status;
        }
    }
    let allTickets = [];
    tickets.forEach(ticket => {
        let params = ticket.split('|');
        allTickets.push(new Ticket(params[0], params[1], params[2]));
    });

    allTickets.sort(sortTickets(method));

    function sortTickets(method) {
        switch (method) {
            case 'destination': return ((a, b) => a.destination.localeCompare(b.destination));
            case 'price': return ((a, b) => a.price - b.price);
            case 'status': return ((a, b) => a.status.localeCompare(b.status));
        }
    }

    return allTickets;
}

console.log(getTickets(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|available',
        'Philadelphia|132.20|departed',
        'Chicago|140.20|available',
        'Dallas|144.60|sold',
        'New York City|206.20|sold',
        'New York City|240.20|departed',
        'New York City|305.20|departed'],
    'status'));