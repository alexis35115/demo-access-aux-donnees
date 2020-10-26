using System.Collections.Generic;

namespace demoAccesDonnees
{
    public class TweetDao : ITweetDao
    {
        public IList<Tweet> RecupererTweets(string courriel)
        {
            var tweets = new List<Tweet>();

            // Interroger l'api de Twitter et préparer les Tweets

            return tweets;
        }
    }
}
