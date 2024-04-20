using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class text_change : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        if (ScoreManager.Score >= Level_change.secondChange) Change(); 
    }

    private void OnEnable()
    {
        ScoreManager.Change_2 += ChangeAfterFewSeconds;
    }

    private void OnDisable()
    {
        ScoreManager.Change_2 -= ChangeAfterFewSeconds;
    }

    private void Change()
    {
        StartCoroutine(ChangeTextColour(0));
    }

    private void ChangeAfterFewSeconds()
    {
        StartCoroutine(ChangeTextColour(1));
    }

    private IEnumerator ChangeTextColour(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        text.color = Color.white;
    }

}
