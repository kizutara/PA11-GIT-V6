using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamemanager : MonoBehaviour
{
    private int Score = 0;
    public Text Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int value)
    {
        Score += value;
        Score++;
        Scoretext.text = "SCORE : " + Score;
    }

}
