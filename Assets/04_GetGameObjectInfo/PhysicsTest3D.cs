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
        Debug.Log(other.gameObject.name + "が乗っているよ！");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "が離れたよ！");
    }
    
    // 当たり判定ゾーン

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "がぶつかったよ！");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + "がすり抜けてるよ！");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "が離れたよ！");
    }
}
