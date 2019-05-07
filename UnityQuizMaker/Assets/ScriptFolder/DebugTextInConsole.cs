using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;


public class DebugTextInConsole : MonoBehaviour
{
    public Text QuestText;
    public Text Antwort1;
    public Text Antwort2;
    public Text Antwort3;
    public Text Antwort4;

    public void Awake()
    {
        ReadMyQuestionPlease();
        PossibleAnswer1();
        PossibleAnswer2();
        PossibleAnswer3();
        PossibleAnswer4();
    }

    public void Start()
    {
        //QuestText.text = "Frage 1 " + myReader.ReadToEnd();
    }
    public void ReadMyQuestionPlease()
    {
        //string myPath = "E:/GIT HUB/QuizMarker/QuizMaker/UnityQuizMaker/Assets/Resources/TextTest.txt";
        string myPath = "Assets/Resources/TextTest.txt";
        StreamReader myReader = new StreamReader(myPath);
        QuestText.text = myReader.ReadToEnd();
        Debug.Log(myReader.ReadToEnd());
        myReader.Close();
    }
    public void PossibleAnswer1()
    {
        string myPath1 = "Assets/Resources/Antwort1.txt";
        StreamReader myReader1 = new StreamReader(myPath1);
        Antwort1.text = myReader1.ReadToEnd();
        Debug.Log(myReader1.ReadToEnd());
        myReader1.Close();
    }
    public void PossibleAnswer2()
    {
        string myPath2 = "Assets/Resources/Antwort2.txt";
        StreamReader myReader2 = new StreamReader(myPath2);
        Antwort2.text = myReader2.ReadToEnd();
        Debug.Log(myReader2.ReadToEnd());
        myReader2.Close();
    }
    public void PossibleAnswer3()
    {
        string myPath3 = "Assets/Resources/Antwort3.txt";
        StreamReader myReader3 = new StreamReader(myPath3);
        Antwort3.text = myReader3.ReadToEnd();
        Debug.Log(myReader3.ReadToEnd());
        myReader3.Close();
    }
    public void PossibleAnswer4()
    {
        string myPath4 = "Assets/Resources/Antwort4.txt";
        StreamReader myReader4 = new StreamReader(myPath4);
        Antwort4.text = myReader4.ReadToEnd();
        Debug.Log(myReader4.ReadToEnd());
        myReader4.Close();
    }
}