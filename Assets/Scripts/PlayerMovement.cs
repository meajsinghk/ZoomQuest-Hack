using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    private Vector2 screenBounds;

    private void Start ()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);

        float clampedX = Mathf.Clamp(transform.position.x, -screenBounds.x, screenBounds.x);
        Vector2 pos = transform.position;
        pos.x = clampedX;
        transform.position = pos;
    }
}
