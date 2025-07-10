using UnityEngine;

public class Generator : MonoBehaviour
{
    float timer = 1;
    float speedUp = 1;
    public GameObject[] gm; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedUp++;
        if (timer > 0) timer -= Time.deltaTime;
        else
        {
            int chance = Random.Range(1, 101);
            float pos_x = Random.Range(-4.0f, 4.0f);

            // Bomb: 20% chance, Gobject: 80%
            if (chance <= 20)
            {
                Instantiate(gm[1], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }
            else
            {
                Instantiate(gm[0], new Vector3(pos_x, 6.0f, 0.1f), new Quaternion(0, 0, 0, 0));
            }

            timer = 1.1f - (speedUp % 10.0f * .1f);
        }
    }
}
