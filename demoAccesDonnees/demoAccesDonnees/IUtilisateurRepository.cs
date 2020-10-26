namespace demoAccesDonnees
{
    public interface IUtilisateurRepository
    {
        void Ajouter(Utilisateur utilisateur);
        void MettreAJour(Utilisateur utilisateur);
        Utilisateur Obtenir(long id);
        void Supprimer(Utilisateur utilisateur);
    }
}