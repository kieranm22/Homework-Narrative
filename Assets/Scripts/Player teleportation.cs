using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerteleportation : MonoBehaviour
{
    public string nextlevel = "Scene 2*";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Run killer");
        switch (collision.tag)
        {
            case "Finish":

                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }


        }
    }
}