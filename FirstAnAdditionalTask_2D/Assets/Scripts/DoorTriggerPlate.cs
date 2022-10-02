using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DoorTriggerPlate : MonoBehaviour
{
    [SerializeField] private DoorSetActive _openedDoor;
    [SerializeField] private DoorSetActive _closedDoor;

    private float _timer;

    private void Update()
    {
        if (_timer > 0)
            _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            _closedDoor.ActivateDoor();
            _openedDoor.DeactivateDoor();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _closedDoor.DeactivateDoor();
        _openedDoor.ActivateDoor();

        _timer = 1f;

        Debug.Log("Door opened");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _timer = 1f;
    }
}
