using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] float gravity = 10;
    CharacterController ch;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = transform.TransformDirection(new Vector3(x, 0, z));
        direction.y -= gravity * Time.deltaTime;
        ch.Move(direction * speed * Time.deltaTime);
    }
}
