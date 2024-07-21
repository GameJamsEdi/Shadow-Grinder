using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float vertical;
    [SerializeField] float horizontal;
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);
    }
}
