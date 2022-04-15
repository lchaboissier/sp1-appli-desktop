# Seven - Contexte

Le groupe Seven a été créé en 1915 en France et est spécialisé dans le service de location de véhicules exclusivement pour des clients grands comptes (donc pas pour des particuliers). Aujourd’hui, le groupe compte jusqu’à 200 agences en France. Pour améliorer son Système d'Information, elle fait appel aux compétences de l'ESN Atos reconnue leader des services IoT.

# Application DESKTOP - 7Activity - Gestion de la flotte de véhicules

L'application desktop 7Activity devra permettre aux employés d'une agence Seven de :

gérer la flotte de véhicules mis à la disposition des clients
de suivre l'activité de l’agence.
En tant qu'utilisateur "seven-agent", je peux disposer des fonctionnalités suivantes :

# FEATURE 1 : Authentification
J'accède à l'application par email (login type nom_p@seven.fr) et mot de passe
Je suis prévenu par un message si mes identifiants sont incorrects 
Une fois connecté, je vois le tableau de bord des réservations qui concerne uniquement mon agence
# FEATURE 2 : Tableau de bord des véhicules en réservations
J'accède au tableau des véhicules réservés et à préparer pour les clients, classé par semaine et demi-journée :
Sur une ligne du tableau je vois :
le modèle
la plaque d'immatriculation
l'entreprise du client
le nom et prénom du conducteur
le statut du véhicule : à préparer, prêt à partir, contrôlé au départ
Sur une ligne du tableau, je peux agir pour :
voir le détails d'une ligne avec en plus :
le kilométrage du véhicule suite au dernier contrôle
la liste des contrôles classée par ordre décroissant de la date
modifier le modèle et le véhicule pour un surclassement
Sur le tableau je peux :
reculer ou avancer dans la liste de semaine en semaine
actualiser la liste en temps réel
J'accède au tableau des véhicules réservés et à restituer par le client, classé par semaine et demi-journée
Sur une ligne du tableau je vois :
le modèle
la plaque d'immatriculation
l'entreprise du client
le nom et prénom du conducteur
agence de départ
le statut du véhicule : contrôlé au départ, contrôlé à l'arrivée
Sur une ligne du tableau, je peux agir pour :
voir le détails d'une ligne
Sur le tableau je peux :
reculer ou avancer dans la liste de semaine en semaine
actualiser la liste en temps réel
# FEATURE 3 : Gestion de la flotte des véhicules
J'accède au tableau des Tableau de bord contenant l'ensemble des informations utiles au nettoyage et à l'entretien des véhicules
Mettre ou non un véhicule à l'entretien : il peut être immobilisé pendant plusieurs jours et n'est donc pas disponible à la location
La possibilité de mettre en vente des véhicules ayant dépassés les 25000 km
# FEATURE 4 : Statistiques sur les réservations
De nouvelles statistiques vont permettre d'anticiper le renouvellement de la flotte de véhicules :

Obtenir le nombre de réservations pour chaque modèle de véhicules, les plus demandés en tête
Voir le nombre de kilomètre pour chaque véhicule
# FEATURE 5 : Profil
Formulaire de profil
Nom
Prénom
Email
Mot de passe (modfiable)
Agence SEVEN