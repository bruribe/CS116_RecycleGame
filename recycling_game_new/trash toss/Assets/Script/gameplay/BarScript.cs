using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript :MonoBehaviour {
    // Serial is what allows to see on the bar when private

    GameObject[] paperObjects;
    GameObject[] metalObjects;
    GameObject[] plasticObjects;
    GameObject[] glassObjects;

    GameObject temp;


    [SerializeField]
	private Image content;
	int score = difficultySettings.score;

	// Use this for initialization
	void Start () {
		content.fillAmount = 1f;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (difficultySettings.isStarted & !difficultySettings.isCompleted)
        {         
			content.fillAmount -= Time.deltaTime * difficultySettings.barDropRate;
			if (score != difficultySettings.score)
            {
                if (throwTrash.correctCollision == true)
                {
                    print(throwTrash.count + " third check");
                    print(" IT WORKED YOUR TAG IS: " + throwTrash.tagHolder.tag);
                    barFill(throwTrash.tagHolder.tag);
                    Destroy(throwTrash.tagHolder);
                }
                //content.fillAmount = content.fillAmount + difficultySettings.barGainRatePlastic;
				//score = difficultySettings.score;
			}
			if (ActivePower.greenAdd)
            {
				content.fillAmount = content.fillAmount + .3f;
				ActivePower.greenAdd = false;

			}
            if (content.fillAmount <= 0)
            {
                difficultySettings.gameOvered = true;
            }
		}
    }

    public void barFill(string tag)
    {
        content.fillAmount -= Time.deltaTime * difficultySettings.barDropRate;
        switch (tag)
        {
            case "Plastic":
                if(throwTrash.count <= 1)
                {
                    content.fillAmount = content.fillAmount + difficultySettings.barGainRatePlastic;
                    score = difficultySettings.score;
                }
                break;
            case "Glass":
                if (throwTrash.count <= 1)
                {
                    content.fillAmount = content.fillAmount + difficultySettings.barGainRateGlass;
                    score = difficultySettings.score;
                }
                break;
            case "Metal":
                if (throwTrash.count <= 1)
                {
                    content.fillAmount = content.fillAmount + difficultySettings.barGainRateMetal;
                    score = difficultySettings.score;
                }
                break;
            case "Paper":
                if (throwTrash.count <= 1)
                {
                    content.fillAmount = content.fillAmount + difficultySettings.barGainRatePaper;
                    score = difficultySettings.score;
                }
                break;
            case "composite":
                if (throwTrash.count <= 1)
                {
                    content.fillAmount = content.fillAmount + difficultySettings.barGainRateCompost;
                    score = difficultySettings.score;
                }
                break;
            default:
                break;
        }
    }
}
