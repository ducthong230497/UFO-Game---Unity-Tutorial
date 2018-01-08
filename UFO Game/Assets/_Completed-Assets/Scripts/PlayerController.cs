using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb2D;
    public Text countText;
    public Text winText;
    private int count;
	// Use this for initialization
	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText(count);
        winText.text = string.Empty;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2D.AddForce(movement * speed);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            SetCountText(++count);
            if (count == 10)
            {
                winText.text = "You win!";
            }
        }
    }

    void SetCountText(int count)
    {
        countText.text = "Count: " + count.ToString();
    }
}
