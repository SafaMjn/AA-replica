using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin_mb : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Color32 color;
    public Rigidbody2D rb;

     void Start()
    {
        foreach (var pinSprite in GetComponentsInChildren<SpriteRenderer>())
        {
            pinSprite.color = color;
        }
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }
    void Update()
    {
        if (!isPinned)
        {
           rb.MovePosition(rb.position +Vector2.up*speed*Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ColorWheel")
        {
            Color32 sectionColor = (Color32)collision.GetComponent<SpriteRenderer>().color;


            if (!sectionColor.Equals(this.color))
            {
                GameManager.Instance.EndGame();
                Debug.Log(color);
            }
        }

        if (collision.tag == "Pin")
        {
            GameManager.Instance.EndGame();
            return;


        } else if (collision.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(collision.transform);
            GameManager.Instance.pinCount += 1;
            GameManager.Instance.SetScore();
        }
    }
}
