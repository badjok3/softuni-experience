function timer() {
    let hours = $('#hours');
    let minutes = $('#minutes');
    let seconds = $('#seconds');

    let time = 0, interval;

    let startBtn = $('#start-timer');
    let stopBtn = $('#stop-timer');

    startBtn.on('click', function () {
        interval = setInterval(increment, 1000);
    });

    stopBtn.on('click', function () {
        clearInterval(interval);
    });

    function increment() {
        time++;
        hours.text(('0' + Math.trunc((time / 60 / 60)) % 24).slice(-2));
        minutes.text(('0' + Math.trunc((time / 60)) % 60).slice(-2));
        seconds.text(('0' + Math.trunc(time % 60)).slice(-2));
    }
}