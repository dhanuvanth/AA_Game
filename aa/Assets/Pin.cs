using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    bool isPinned = false;

    // Update is called once per frame
    void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "rotator")
        {
            transform.SetParent(collision.transform);
            //change rotation direction
            //collision.GetComponent<Rotator>().speed *= -1;
            Score.pinCount++;
            isPinned = true;
        }else if(collision.tag == "pins")
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
