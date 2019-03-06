using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvents", menuName = "Quiz/new GameEvent")]
public class GameEvents : ScriptableObject
{

    public delegate void UpdateQuestionUICallback(Question question);
    public UpdateQuestionUICallback UpdateQuestionUI;

    public delegate void UpdateQuestAnswerCallback(AnswerData pickedAnswer);
    public UpdateQuestAnswerCallback UpdateQuestionAnswer;

    public delegate void DisplayResolutionScreenCallback( int score); //UIManager.ResolutionScreenType type
    public DisplayResolutionScreenCallback DisplayResolutionScreen;

    public delegate void ScoreUpdatedCallback();
    public ScoreUpdatedCallback ScoreUpdated;

    public int CurrentFinalScore;



}
