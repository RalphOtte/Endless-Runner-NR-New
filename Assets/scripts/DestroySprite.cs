using UnityEngine;
using System.Collections;

public class DestroySprite : MonoBehaviour {

    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }


}
