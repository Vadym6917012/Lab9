using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetActive : MonoBehaviour
{
    public void DeactivateDoor()
    {
        gameObject.SetActive(false);
    }

    public void ActivateDoor()
    {
        gameObject.SetActive(true);
    }
}
