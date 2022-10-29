using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    public OVRInput.Controller my_controller = OVRInput.Controller.None;
    bool colorchanged = false;
    public Color defaultColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float reading = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, my_controller);
        if (reading > 0.7f)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            colorchanged = true;
            Debug.Log("Triggered");
        }
        if(OVRInput.GetDown(OVRInput.Button.One, my_controller))
        {
            if (colorchanged)
            {
                GetComponent<MeshRenderer>().material.color = defaultColor;
                colorchanged = false;
                Debug.Log("button pressed");
            }
            else
            {
                GetComponent<MeshRenderer>().material.color = Color.red;
                colorchanged = true;
                Debug.Log("button pressed X 2");
            }

        }
    }
}
