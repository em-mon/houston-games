using UnityEngine;

public class Player : MonoBehaviour
{
    Transform tr;
    SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Move right
        if (Input.GetKey("right") == true)
        {
            // If flipped, unflip
            if (sr.flipX) sr.flipX = false;
            if (tr.position.x < 4f) tr.position += new Vector3(0.2f, 0f, 0f);
        }

        // Move left
        if (Input.GetKey("left") == true)
        {
            // If unflipped, flip
            if (!sr.flipX) sr.flipX = true;
            if (tr.position.x > -4f) tr.position += new Vector3(-0.2f, 0f, 0f);
        }
    }
}

