namespace demoAccesDonnees
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly IUtilisateurDao _utilisateurDao;
        private readonly ITweetDao _tweetDao;

        public UtilisateurRepository(IUtilisateurDao utilisateurDao,
            ITweetDao tweetDao)
        {
            _utilisateurDao = utilisateurDao;
            _tweetDao = tweetDao;
        }

        public Utilisateur Obtenir(long id)
        {
            var utilisateur = (UtilisateurMediasSociaux)_utilisateurDao.Lire(id);

            utilisateur.Tweets = _tweetDao.RecupererTweets(utilisateur.Email);

            return utilisateur;
        }

        public void Ajouter(Utilisateur utilisateur)
        {
            _utilisateurDao.Creer(utilisateur);
        }

        public void MettreAJour(Utilisateur utilisateur)
        {
            _utilisateurDao.MettreAJour(utilisateur);
        }

        public void Supprimer(Utilisateur utilisateur)
        {
            _utilisateurDao.Supprimer(utilisateur.Id);
        }
    }
}
