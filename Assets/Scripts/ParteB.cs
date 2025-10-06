using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParteB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Parte B");
        Debug.Log(Game.Lives);
        StartCoroutine(WaitAndLog());
    }

    private IEnumerator WaitAndLog()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("Waited for 10 seconds");
    }
}
