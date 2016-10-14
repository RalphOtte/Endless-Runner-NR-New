using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    [SerializeField]private HeightMeter heightmeter;
    [SerializeField]private PlayerData playerdata;

    public float currentScore;

	void Start () {
	  //playerHeight += Time.deltaTime * (1+playerHeight / 10)

	}
	
	void Update () {
        currentScore += Mathf.Floor( Time.deltaTime * (1 + heightmeter.yPos / 7)*3);
        playerdata.currentScore = currentScore;
        Debug.Log("Score " + currentScore);	
	}
}
