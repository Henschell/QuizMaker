using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using System.CodeDom;

public class ReadWriteXML : MonoBehaviour {

    public static ReadWriteXML RWManager;
    string str = @"<?xml version= "" 1.0 "" encoding= "" utf-8 "" ?>
<Team> 
			<teamName> </teamName>
			<teammitglieder> </teammitglieder>
			<teamPunkte> </teamPunkte> 
            <!-- Antworten der jeweiligen fragen? -->
			
</Team>";

    void Awake()
    {
       // Console.WriteLinedoc1(str);
        //XDocument doc2 = XDocument.Parse(str, LoadOptions.None);
        //Console.WriteLine(doc2.DescendantNodes().Count());

        //RWManager = this;

        //XDocument doc = XDocument.Parse(str);
       // Console.WriteLine(doc);
    }
    public void Start()
    {
        Debug.Log(str);
        XDocument doc1 = XDocument.Parse(str);
    }

    public PunkeSpeichern pSP;

	void Texti () {
        //TextAsset txtXmlTeam = Resources.Load<TextAsset>("Team");
	}
	
[System.Serializable]
public class Team
    {
        public string teamName;
        public int teamPunkte;

    }
[System.Serializable]
public class PunkeSpeichern
    {
        public List<Team> pointList = new List <Team>(); 
    }
}
