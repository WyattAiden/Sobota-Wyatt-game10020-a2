using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Movesp;
    public Rigidbody2D Rigidbody;
    public Vector2 Moveip;

    Collider2D Objectcolide;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moveip.x = Input.GetAxisRaw("Horizontal");
        Moveip.y = Input.GetAxisRaw("Vertical");

        Moveip.Normalize();

        Rigidbody.velocity = Moveip * Movesp;

        if (Input.GetKeyDown(KeyCode.E) && Objectcolide != null)
        {
            if (Objectcolide.GetComponent<Torch>() != null)
            {
                Torch torch = Objectcolide.GetComponent<Torch>();
                torch.PlayerLight();
            }
            else if (Objectcolide.GetComponent<Door>() != null)
            {
                Door door = Objectcolide.GetComponent<Door>();
                door.DoorOpen();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Objectcolide = collision;
        if (Objectcolide.GetComponent<PreshurePlate>() != null)
        {
            PreshurePlate preshurePlate = Objectcolide.GetComponent<PreshurePlate>();
            preshurePlate.Playersteped();
        }
    }
}
