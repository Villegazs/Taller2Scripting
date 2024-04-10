using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void OnClickKill()
    {
        GameplayManager.instance.IncreaseKillCount(1);
        Debug.Log("You have killed "+ GameplayManager.instance.GetKillCount()+" Enemies");

    }
}
