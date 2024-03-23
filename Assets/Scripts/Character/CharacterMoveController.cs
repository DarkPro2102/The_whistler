using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardDirection = Input.GetAxis("Vertical");
        float horizontalDirection = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalDirection, 0, forwardDirection) * moveSpeed * Time.deltaTime;
    }
}
