using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballMovement;
    public float ballSpeedHitted;
    public float maxspeedhitted;

    int hitcounter = 0;
        // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        // move right and left each of turn
        this.hitcounter = 0;
        yield return new WaitForSeconds(2);

        if (isStartingPlayer1)//x is right and y is left
            this.MoveBall(new Vector2(-1, 0));
        else
            this.MoveBall(new Vector2(1, 0));
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.ballMovement + this.ballSpeedHitted * hitcounter;

        Rigidbody2D myrigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

        myrigidBody2D.velocity = dir * speed;
    }
}
