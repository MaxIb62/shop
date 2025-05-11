using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activate : MonoBehaviour
{
    public Canvas canvasToActivate;

    private void Start()
    {
        if (canvasToActivate != null)
            canvasToActivate.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            if (canvasToActivate != null)
                canvasToActivate.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            if (canvasToActivate != null)
                canvasToActivate.enabled = false;
        }
    }
}
