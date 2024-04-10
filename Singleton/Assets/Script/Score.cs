using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickScore()
    {
        GameplayManager.instance.IncreaseScore(1);
        Debug.Log("You have gained " + GameplayManager.instance.GetScore() + " Scores");

    }
}
