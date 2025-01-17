using UnityEngine;

public class Bullet : MonoBehaviour
{
    public UI ui;
    private Rigidbody2D rb => GetComponent<Rigidbody2D>();

    void Update() => transform.right = rb.linearVelocity;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Target")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            UI.instance.AddScore();
        }
    }
}
