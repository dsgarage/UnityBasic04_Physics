using UnityEngine;

public class Collision3D : MonoBehaviour
{
 private void OnCollisionEnter(Collision other)
 {
  Debug.Log("当たった時に呼ばれる");
 }

 private void OnCollisionExit(Collision other)
 {
  Debug.Log("離れた時に呼ばれる");
 }

 private void OnCollisionStay(Collision other)
 {
  Debug.Log("当たっている間ずっと呼ばれる");
 }
}
 