using System;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsTest2D : MonoBehaviour
{
    //衝突判定ゾーン
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name + "にぶつかったよ！");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name + "から離れたよ！");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name + "をすり抜けてるよ！");
    }
    
    //当たり判定ゾーン
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name + "にぶつかったよ！");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name + "をすり抜けてるよ！");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name + "から離れたよ！");
    }

}
