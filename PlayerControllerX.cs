using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool timeOut = true;
    public float relax = 1.5f;
    // Update is called once per frame
    void Update()
    {// On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeOut == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            private float timer += Time.deltaTime;
        }
if (timer >= relax)
{
    timeOut = true;
    timer = 0f;
}
else
{
    timeOut = false;
}
    } 
}



        


         




