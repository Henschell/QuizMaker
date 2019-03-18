using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

[SerializeField()]
public struct UIManagerParameters
{
    [Header("Answers Options")]
    [SerializeField] float margins;
    public float Margins { get { return margins; } }

}
[SerializeField()]
public struct UIElements
{
    [SerializeField] RectTransform answersContentArea;
    public RectTransform AnswersContentArea { get { return answersContentArea; } }
    [SerializeField] TextMeshProUGUI questionInfoTextObject ;
    public TextMeshProUGUI QuestionInfoTextObject { get { return questionInfoTextObject; } }
    [SerializeField] TextMeshProUGUI scoreText ;
    public TextMeshProUGUI ScoreText { get { return scoreText; } }
    [Space]
    [SerializeField] Image resolutionBG;
    public Image ResolutionBG { get { return resolutionBG; } }
    [SerializeField] TextMeshProUGUI resolutionStateInfoText;
    public TextMeshProUGUI ResolutionStateInfoText { get { return resolutionStateInfoText; } }
    [SerializeField] TextMeshProUGUI resolutionScoreText;
    public TextMeshProUGUI ResolutionScoreText { get { return resolutionScoreText; } }
    [Space]
    [SerializeField] TextMeshProUGUI highscoreText ;
    public TextMeshProUGUI HighscoreText { get { return highscoreText; } }
    [SerializeField] CanvasGroup mainCanvasGroup;
    public CanvasGroup MainCanvasGroup { get { return mainCanvasGroup; } }
    [SerializeField] RectTransform finishUIElements;
    public RectTransform FinishUIElements { get { return finishUIElements; } }

}
public class UIManager : MonoBehaviour
{

    public enum ResolutionScreenType { correct, Incorrect, Finish }

    [Header("References")]
    [SerializeField] GameEvents events;

    [Header("UI Elements (Prefabs)")]
    [SerializeField] AnswerData answerPrefab;

    [SerializeField] UIElements uIElements;

    [Space]
    [SerializeField] UIManagerParameters parameters;

    List<AnswerData> currentAnswer = new List<AnswerData>();

     void OnEnable()
    {
        
    }

    void OnDisable()
    {

    }
    void UpdateQuestionUI (Question question)
    {

    }
}
