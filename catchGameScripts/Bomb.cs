using UnityEngine;

public class Bomb : MonoBehaviour
{
    Main main;
    Transform tr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("Scripts").GetComponent<Main>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, 0.12f, 0f);

        if (tr.position.y < -7f) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "astros_player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            main.GameOver = true;
        }
    }
}

