using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public GameObject dimension1Parent;
    public GameObject dimension2Parent;
    //true = d1, false = d2
    public bool dimension;
    // Start is called before the first frame update
    void Start()
    {
        dimension2Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dimension)
            {
                dimension1Enable();
                dimension2Disable();
            }
            else
            {
                dimension2Enable();
                dimension1Disable();
            }
        }
    }

    public void dimension1Enable()
    {
        for (int i = 0; i < dimension1Parent.transform.childCount; i++)
        {
            dimension1Parent.transform.GetChild(i).gameObject.SetActive(true);
        }
        dimension = false;
    }
    public void dimension1Disable()
    {
        for (int i = 0; i < dimension1Parent.transform.childCount; i++)
        {
            dimension1Parent.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
    public void dimension2Enable()
    {
        for (int i = 0; i < dimension2Parent.transform.childCount; i++)
        {
            dimension2Parent.transform.GetChild(i).gameObject.SetActive(true);
        }
        dimension = true;
    }
    public void dimension2Disable()
    {
        for (int i = 0; i < dimension2Parent.transform.childCount; i++)
        {
            dimension2Parent.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}

