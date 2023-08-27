using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        shapeName = "Capsule";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void DisplayText(){
        showText.SetText("This " + shapeName + " is " + shapeColor);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
