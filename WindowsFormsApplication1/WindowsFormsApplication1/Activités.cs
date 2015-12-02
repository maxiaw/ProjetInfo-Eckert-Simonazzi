﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

public class Activités
{

    private int idActivité;
    private DateTime heureDebut;
    private string texteDescriptif;
    private string typeActivite;
    private DateTime heureFin;
    private string statutActivite;
    Lieu lieuActivite;
    private static int nbActivité = 0;
    private string nomActivité;
    private List<Astronautes> listeAstronautes = new List<Astronautes>();
    
    //Constructeur par défaut
    public Activités(string nom, string type, DateTime hDebut, DateTime hFin, Lieu tempLieuActivite, List<Astronautes> tempListeAstronautes, string tempTexteDescriptif)
    {
        nbActivité++;
        nomActivité = nom;
        idActivité = nbActivité;
        heureDebut = hDebut;
        heureFin = hFin;
        typeActivite = type;
        lieuActivite = tempLieuActivite;
        listeAstronautes = tempListeAstronautes;
        texteDescriptif = tempTexteDescriptif;
    }



  

    //Accesseurs//
    public string GetNomActivité
    {
        get { return nomActivité; }
        set { nomActivité = value; }
    }

   
    public string getDateDebutMars(DateTime tempDateDebutPlanning)
    {
        DateTime dateDebutPlanning = tempDateDebutPlanning;

        TimeSpan ecart = heureDebut - dateDebutPlanning;

        int intervalleTempsDebutActivite = ecart.Days * 60 * 24 + ecart.Hours * 60 + ecart.Minutes + ecart.Days * 40;

        double doubleIntervalleTempsDebutActivite = intervalleTempsDebutActivite - (ecart.Days * 60 * 24);

        int horaireDebutHeure = (int)Math.Truncate(doubleIntervalleTempsDebutActivite / 60);
        int horaireDebutMinute = (int)doubleIntervalleTempsDebutActivite - horaireDebutHeure * 60;

        string conversionDebut = horaireDebutHeure.ToString() + "h"+ horaireDebutMinute.ToString();

        return conversionDebut;

    }

    public string getDateFinMars(DateTime tempDateDebutPlanning)
    {
        DateTime dateDebutPlanning = tempDateDebutPlanning;


        TimeSpan ecart = heureFin - dateDebutPlanning;


        int intervalleTempsDebutActivite = ecart.Days * 60 * 24 + ecart.Hours * 60 + ecart.Minutes + ecart.Days * 40;

        double doubleIntervalleTempsDebutActivite = intervalleTempsDebutActivite - (ecart.Days * 60 * 24);

        int horaireDebutHeure = (int)Math.Truncate(doubleIntervalleTempsDebutActivite / 60);
        int horaireDebutMinute = (int)doubleIntervalleTempsDebutActivite - horaireDebutHeure * 60;

        string conversionDebut = horaireDebutHeure.ToString() + "h" + horaireDebutMinute.ToString();

        return conversionDebut;

    }



	public DateTime getHeureDebut
	{
		get { return heureDebut; }
		set { heureDebut = value; }
	}

	public DateTime GetheureFin
	{
		get{return heureFin;}
		set{heureFin=value;}
	}

	public string GettexteDescriptif
	{
		get{return texteDescriptif;}
		set{texteDescriptif=value;}
	}

	public string GettypeActivite
	{
		get{return typeActivite;}
		set{typeActivite=value;}
	}

	public string GetstatutActivite
	{
		get{return statutActivite; }
		set{statutActivite =value;}
	}

    public Lieu GetLieuActivite
    {
        get { return lieuActivite; }
        set { lieuActivite = value; }
    }


	public virtual List<Astronautes> GetlisteAstronautes
	{
        get { return listeAstronautes; }
        set { listeAstronautes = value; }
	}

    public string GetnomActivite
    {
        get{return nomActivité;}
        set { nomActivité = value; }
    }
    public int GetnbActivité
    {
        get { return nbActivité; }
        set { nbActivité = value; }
    }

    public string GetNomLieuDeActivite
    {
        get{return lieuActivite.GetnomLieu;}
        
    }

    
    //FinAccesseurs

	public virtual void RenvoieActiviteParMotCle()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ajouterLieu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void supprimerLieu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ajouterAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void supprimerAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getListeAstronautes()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getLieu()
	{
		throw new System.NotImplementedException();
	}

}

