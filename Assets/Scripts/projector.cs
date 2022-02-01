using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projector : MonoBehaviour
{
    // Start is called before the first frame update
    private Projector proj;
    private int count;

    void Start()
    {
        // Get the projector
        proj = GetComponent<Projector>();
        // Use it
        // proj.nearClipPlane = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        proj.fieldOfView = 1;
        // Instantiate(proj);
        if (count % 2000 == 0)
        {
            // Projector newprog = Instantiate(proj);
            // print("posi" +  GameObject.Find("Projector").transform.eulerAngles);
            // newprog.transform.position = GameObject.Find("Projector").transform.position;
            // // newprog.transform.Rotate = (GameObject.Find("Projector").transform.eulerAngles.x, 
            // // GameObject.Find("Projector").transform.eulerAngles.y, 
            // // GameObject.Find("Projector").transform.eulerAngles.z);
            // // newprog.transform.Rotate(GameObject.Find("Projector").transform.eulerAngles, Space.World);
            // newprog.transform.eulerAngles = GameObject.Find("Projector").transform.eulerAngles;
            // print("posi1" +  newprog.transform.eulerAngles);
        }
        count ++;
    }
}

