namespace _04.Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var left = new string(ticket.Take(10).ToArray());
                    var right = new string(ticket.Skip(10).Take(10).ToArray());

                    var winningSymbols = new string[] { "@", "#", "\\^", "\\$" };
                    var hasMatched = false;

                    foreach (var symbol in winningSymbols)
                    {
                        var regex = new Regex($@"{symbol}{{6,}}");
                        var match = regex.Match(left);
                        if (match.Success)
                        {
                            var rightMatch = regex.Match(right);
                            if (rightMatch.Success)
                            {
                                if (rightMatch.Length == match.Length && match.Length == 10)
                                {
                                    hasMatched = true;
                                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(rightMatch.Length, match.Length)}{symbol.Trim('\\')} Jackpot!");
                                }
                                else
                                {
                                    hasMatched = true;
                                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(rightMatch.Length, match.Length)}{symbol.Trim('\\')}");
                                }
                            }
                        }
                    }

                    if (!hasMatched)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }

                }
            }
        }
    }
}