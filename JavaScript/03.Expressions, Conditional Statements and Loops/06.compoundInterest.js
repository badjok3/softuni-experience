function compoundInterest([sum, ratePercent, period, timespan]) { 
   period = 12 / period;

   let interest = Math.pow((1 + (ratePercent / 100) / period), period * timespan);

   return sum * interest;
}