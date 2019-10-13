using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int PinCount;

	public Text text;
    public Text HighScore;

    void Start ()
	{
		PinCount = 0;
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

	}

	void Update ()
	{
		text.text = PinCount.ToString();
        
        if(PinCount > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", PinCount);
            HighScore.text = PinCount.ToString();
        }
	}
    
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
    }

}
