using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Jumper : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void Update()
    {
        // when user click left mouse
        if (Input.GetMouseButtonDown(0))
        {
            // convert mouse click screen position in world position
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // when convert z = -10 so set z = 0 to make object appear in screen
            worldPosition.z = 0;
            //GetComponent<Rigidbody2D>().AddForce(worldPosition, ForceMode2D.Impulse);
            transform.position = worldPosition; 
        }        
    }
}
