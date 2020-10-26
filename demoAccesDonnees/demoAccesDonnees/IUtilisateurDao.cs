namespace demoAccesDonnees
{
    public interface IUtilisateurDao
    {
        void Creer(Utilisateur utilisateur);
        void MettreAJour(Utilisateur utilisateur);
        Utilisateur Lire(long id);
        void Supprimer(long id);
    }
}