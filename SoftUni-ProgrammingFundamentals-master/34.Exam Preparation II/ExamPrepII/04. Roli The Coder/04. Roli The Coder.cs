using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main()
        {
            var eventsRegex = new Regex(@"(?<id>\d+)\s+#(?<event>\w+)\s*(?<participants>(?:@[\dA-Za-z'\-]+\s*)*)");

            var events = new Dictionary<int, Event>();

            while (true)
            {
                var input = Console.ReadLine();

                if ("Time for Code".Equals(input))
                {
                    break;
                }

                var evnt = eventsRegex.Match(input);

                if (!evnt.Success)
                {
                    continue;
                }

                var id = int.Parse(evnt.Groups["id"].Value);
                var eventName = evnt.Groups["event"].Value;
                var participantsStr = evnt.Groups["participants"].Value;

                if (events.ContainsKey(id))
                {
                    if (!events[id].Name.Equals(eventName))
                    {
                        continue;
                    }
                }
                else
                {
                    events[id] = new Event(eventName);
                }

                if (participantsStr.Length > 0)
                {
                    events[id].Participants.UnionWith(
                        participantsStr
                            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
                }
            }

            var sortedEvents = events
                .OrderByDescending(pair => pair.Value.Participants.Count)
                .ThenBy(a => a.Value.Name)
                .Select(a => a.Value)
                .ToList();

            foreach (var sortedEvent in sortedEvents)
            {
                Console.WriteLine(sortedEvent);
            }
        }

        private class Event
        {
            public string Name { get; }

            public SortedSet<string> Participants { get; }

            public Event(string name)
            {
                Name = name;
                Participants = new SortedSet<string>();
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append($"{Name} - {Participants.Count}");

                if (Participants.Count > 0)
                {
                    sb.Append(Environment.NewLine);
                    sb.Append(string.Join(Environment.NewLine, Participants));
                }

                return sb.ToString();
            }
        }
    }
}
