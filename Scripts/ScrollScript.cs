using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public RawImage rawImage;
    

    // Update is called once per frame
    void Update()
    {
        rawImage.uvRect = new Rect(rawImage.uvRect.position + new Vector2(1,0) * Time.deltaTime, rawImage.uvRect.size);
    }
}
