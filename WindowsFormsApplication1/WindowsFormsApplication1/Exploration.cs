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

public class Exploration : Activités
{
    private string typeExploration;


    //Constructeur par défaut
    public Exploration(string tempTypeExploration, string nom, DateTime hDebut, DateTime hFin, Lieu tempNomLieu, List<Astronautes> tempListeAstronautes)
        : base(nom, "Exploration", hDebut, hFin, tempNomLieu, tempListeAstronautes)
    {
        typeExploration = tempTypeExploration;
    }

    //Accesseurs//
	public string GettypeExploration
	{
        get { return typeExploration; }
        set { typeExploration = value; }
	}
    //FinAccesseurs//
}

