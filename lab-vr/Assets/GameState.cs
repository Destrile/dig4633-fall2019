using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int numSnapped = 0;
    public GameObject WinText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerUnSnap()
    {
        Debug.Log("Snapped");
        numSnapped = numSnapped - 1;
    }

    public void OnTriggerSnap()
    {
        Debug.Log("Snapped");
        numSnapped = numSnapped + 1;
        if (numSnapped == 2)
        {
            Debug.Log("Finished");
            WinText.SetActive(true);
        } else
        {
            Debug.Log("Not Finished");
        }
    }
}
