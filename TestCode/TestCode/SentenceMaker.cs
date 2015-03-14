namespace TestCode
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The sentence maker.
    /// </summary>
    public static class SentenceMaker
    {
        /// <summary>
        /// The nouns.
        /// </summary>
        private static readonly List<string> Nouns = new List<string>
                                                         {
                                                             "stew",
                                                             "railway",
                                                             "yak",
                                                             "teeth",
                                                             "achiever",
                                                             "laugh",
                                                             "use",
                                                             "event",
                                                             "crow",
                                                             "duck",
                                                             "pin",
                                                             "earth",
                                                             "ocean",
                                                             "sink",
                                                             "foot",
                                                             "tongue",
                                                             "screw",
                                                             "cloth",
                                                             "distance",
                                                             "plate",
                                                             "paper",
                                                             "hammer",
                                                             "neck",
                                                             "chalk",
                                                             "thrill",
                                                             "yarn",
                                                             "hose",
                                                             "grandfather",
                                                             "hour",
                                                             "sticks",
                                                             "crayon",
                                                             "letter",
                                                             "quilt",
                                                             "toe",
                                                             "week",
                                                             "measure",
                                                             "cakes",
                                                             "shoe",
                                                             "laborer",
                                                             "self",
                                                             "force",
                                                             "heat",
                                                             "harbor",
                                                             "bucket",
                                                             "sneeze",
                                                             "start",
                                                             "river",
                                                             "increase",
                                                             "guitar",
                                                             "fear",
                                                             "action",
                                                             "wilderness",
                                                             "bone",
                                                             "pets",
                                                             "glass",
                                                             "adjustment",
                                                             "linen",
                                                             "judge",
                                                             "hill",
                                                             "governor",
                                                             "top",
                                                             "pipe",
                                                             "range",
                                                             "beds",
                                                             "condition",
                                                             "string",
                                                             "destruction",
                                                             "dirt",
                                                             "end",
                                                             "front",
                                                             "transport",
                                                             "kettle",
                                                             "dust",
                                                             "vein",
                                                             "skirt",
                                                             "country",
                                                             "debt",
                                                             "eggs",
                                                             "existence",
                                                             "tiger",
                                                             "leather",
                                                             "cap",
                                                             "leg",
                                                             "road",
                                                             "price",
                                                             "rice",
                                                             "respect",
                                                             "books",
                                                             "flower",
                                                             "partner",
                                                             "crook",
                                                             "size",
                                                             "passenger",
                                                             "pump",
                                                             "rain",
                                                             "cover",
                                                             "smell",
                                                             "lunchroom",
                                                             "work",
                                                             "sisters"
                                                         };

        /// <summary>
        /// The verbs.
        /// </summary>
        private static readonly List<string> Verbs = new List<string>
                                                         {
                                                             "rejoice",
                                                             "allow",
                                                             "wander",
                                                             "save",
                                                             "cheer",
                                                             "regret",
                                                             "fail",
                                                             "tire",
                                                             "manage",
                                                             "analyse",
                                                             "greet",
                                                             "chew",
                                                             "tap",
                                                             "head",
                                                             "realise",
                                                             "snore",
                                                             "arrive",
                                                             "queue",
                                                             "obtain",
                                                             "disappear",
                                                             "receive",
                                                             "kneel",
                                                             "present",
                                                             "snow",
                                                             "spot",
                                                             "doubt",
                                                             "cheat",
                                                             "care",
                                                             "back",
                                                             "haunt",
                                                             "water",
                                                             "wash",
                                                             "note",
                                                             "rock",
                                                             "trip",
                                                             "moan",
                                                             "consider",
                                                             "notice",
                                                             "grip",
                                                             "applaud",
                                                             "welcome",
                                                             "form",
                                                             "instruct",
                                                             "command",
                                                             "tumble",
                                                             "spill",
                                                             "behave",
                                                             "twist",
                                                             "shrug",
                                                             "argue",
                                                             "record",
                                                             "shop",
                                                             "irritate",
                                                             "spell",
                                                             "replace",
                                                             "smile",
                                                             "mark",
                                                             "damage",
                                                             "hand",
                                                             "bang",
                                                             "screw",
                                                             "guide",
                                                             "drag",
                                                             "polish",
                                                             "reply",
                                                             "ban",
                                                             "continue",
                                                             "crawl",
                                                             "scratch",
                                                             "delay",
                                                             "need",
                                                             "check",
                                                             "matter",
                                                             "play",
                                                             "curl",
                                                             "collect",
                                                             "smash",
                                                             "float",
                                                             "hang",
                                                             "annoy",
                                                             "tremble",
                                                             "warm",
                                                             "tip",
                                                             "accept",
                                                             "ask",
                                                             "expect",
                                                             "join",
                                                             "bless",
                                                             "miss",
                                                             "wreck",
                                                             "excite",
                                                             "squeeze",
                                                             "wriggle",
                                                             "tug",
                                                             "x-ray",
                                                             "influence",
                                                             "groan",
                                                             "post",
                                                             "wrestle",
                                                             "trouble",
                                                         };

        /// <summary>
        /// The articles.
        /// </summary>
        private static readonly List<string> Articles = new List<string>
                                                            {
                                                                "the", "a[n]", "one", "some", "any"
                                                            };

        /// <summary>
        /// The prepositions.
        /// </summary>
        private static readonly List<string> Preposition = new List<string>
                                                               {
                                                                   "to", "from", "over", "under", "on"
                                                               };

        /// <summary>
        /// The random index of the word.
        /// </summary>
        private static readonly Random Rand = new Random();

        /// <summary>
        /// Generate a random sentence.
        /// </summary>
        /// <param name="length">
        /// The length. [ max is 6]
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string Generate(int length = 6)
        {
            var response = string.Empty;

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        response += Articles[Rand.Next(0, Articles.Count)] + " ";
                        break;

                    case 1:
                        response += Nouns[Rand.Next(0, Nouns.Count)] + " ";
                        break;

                    case 2:
                        response += Verbs[Rand.Next(0, Verbs.Count)] + " ";
                        break;

                    case 3:
                        response += Preposition[Rand.Next(0, Preposition.Count)] + " ";
                        break;

                    case 4:
                        response += Articles[Rand.Next(0, Articles.Count)] + " ";
                        break;

                    case 5:
                        response += Nouns[Rand.Next(0, Nouns.Count)] + ".";
                        break;
                }
            }

            return char.ToUpper(response[0]) + response.Substring(1);
        }
    }
}