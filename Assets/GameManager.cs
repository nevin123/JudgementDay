using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text ScoreText;
	
    void Start()
    {
        ScoreText.text = "0";
    }

	void Update () {
        ScoreText.text = Time.time.ToString("0");
	}
}
