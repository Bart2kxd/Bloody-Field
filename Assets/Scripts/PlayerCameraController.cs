using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] float mouseSense = 1;

    [SerializeField] float minVert = -45;
    [SerializeField] float maxVert = 45;

    float rotateY = 0;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        rotateY -= Input.GetAxis("Mouse Y") * mouseSense;

        Vector3 rotPlayer = transform.rotation.eulerAngles;

        rotPlayer.x = Mathf.Clamp(rotateY, minVert, maxVert);
        rotPlayer.z = 0;
        rotPlayer.y += rotateX;

        transform.rotation = Quaternion.Euler(rotPlayer);
    }
}
