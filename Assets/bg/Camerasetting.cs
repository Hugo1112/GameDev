using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerasetting : MonoBehaviour
{
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        ScreenCredentials();
    }
    public void ScreenCredentials()
    {
        var height = Camera.main.orthographicSize * 2;
        var width = height * Screen.width / Screen.height;
        var backg = background.GetComponent<SpriteRenderer>().sprite;
        var unitWidth = backg.textureRect.width / backg.pixelsPerUnit;
        var unitHeight = backg.textureRect.height / backg.pixelsPerUnit;
        background.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(width / unitWidth, height / unitHeight);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
