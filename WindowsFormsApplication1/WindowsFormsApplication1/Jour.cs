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

public class Jour
{
    private int idJour;
    private static int nbJour = 0;
	public int GetidJour
    {
        get { return idJour; }
        set { idJour = value; }
    }

	private string compteRendu


	public virtual string etatActivite
	{
		get;
		set;
	}

	public virtual Planning Planning
	{
		get;
		set;
	}

	public virtual IEnumerable<Activités> listeActivite
	{
		get;
		set;
	}
    public Jour() 
    {
        nbJour++;
        idJour=nbJour;
    }
    



	public virtual void ajouterActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void modifierActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void supprimerActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void modifierCompteRendu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void clearActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void getListeActivite()
	{
		throw new System.NotImplementedException();
	}

	public virtual void motCleContenuDansCR()
	{
		throw new System.NotImplementedException();
	}

	public virtual void motCleContenuDansTDActivite()
	{
		throw new System.NotImplementedException();
	}

}

