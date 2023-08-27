using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    [SerializeField] protected string shapeColor;
    [SerializeField] protected TextMeshProUGUI showText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected abstract void DisplayText();
}
