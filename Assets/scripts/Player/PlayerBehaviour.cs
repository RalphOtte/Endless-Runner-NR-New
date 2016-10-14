using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    private HeightMeter playerHeight;
    private PlayerData playerData;

    void Start ()
    {
        playerHeight = GetComponent<HeightMeter>();
        playerData = GetComponent<PlayerData>();    
	}

	void Update ()
    {
        UpdatePlayerHeight();
	}

    void UpdatePlayerHeight()
    {
        playerData.currentHeight = playerHeight.yPos;
        //Debug.Log("playerdata" + playerData.currentHeight);
        //Debug.Log("playerHeight" + playerHeight.yPos);
    }

}
