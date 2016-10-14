using UnityEngine;
using System.Collections;

public class DestroyOutOfBounds : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    void Start()
    {
        Destroy(gameObject, 10);
    }
	
}
