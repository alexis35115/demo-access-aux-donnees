using System.Collections.Generic;

namespace demoAccesDonnees
{
    public class UtilisateurMediasSociaux : Utilisateur
    {
        public IList<Tweet> Tweets { get; set; }
    }
}
