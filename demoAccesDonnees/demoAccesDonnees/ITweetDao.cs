using System.Collections.Generic;

namespace demoAccesDonnees
{
    public interface ITweetDao
    {
        IList<Tweet> RecupererTweets(string courriel);
    }
}
