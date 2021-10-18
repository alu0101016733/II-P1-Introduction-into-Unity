using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoLog : MonoBehaviour
{   
    public uint identifier;
    private uint counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        printInfo();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        printInfo();

    }

    void printInfo() {
        Debug.Log("Name: " + name + ", ID: " + identifier + ", counter: " + counter);
    }
}
