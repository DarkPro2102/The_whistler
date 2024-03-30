using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        if (camTransform == null)
        {
            camTransform = Camera.main.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float forwardDirection = Input.GetAxis("Vertical");
        float horizontalDirection = Input.GetAxis("Horizontal");
        transform.position += (camTransform.forward * forwardDirection + camTransform.right * horizontalDirection) * moveSpeed * Time.deltaTime;
    }
}
