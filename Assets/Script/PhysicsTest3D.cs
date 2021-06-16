using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsTest3D : MonoBehaviour
{
    //衝突判定ゾーン
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + "がぶつかったよ！");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name + "に乗っているよ！");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "から離れたよ！");
    }
    
    // 当たり判定ゾーン

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "がぶつかったよ！");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + "をすり抜けてるよ！");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "から離れたよ！");
    }
}
