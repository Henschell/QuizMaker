using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class iTimer : MonoBehaviour
{

    public int MyTimer = 120; // Wenn 0 erreicht wird, wird automatisch die nächste szene aufgerufen / Frage.
    public Text MyTimerText;

    void Start()
    {
        StartCoroutine(TimeIt());
    }

    IEnumerator TimeIt()
    {
        MyTimer--;
        yield return new WaitForSeconds(1);
        MyTimerText.text = MyTimer.ToString();
        StartCoroutine(TimeIt());
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
