using UnityEngine;
using System.Collections;

public class HeightMeter : MonoBehaviour {

    public float yPos;
    public float xPos;
	
	void Update ()
    {
        yPos = transform.position.y;
        xPos = transform.position.x;
	}
}
