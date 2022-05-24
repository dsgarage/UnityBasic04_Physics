using UnityEngine;

public class Trigger3D : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
 {
  Debug.Log("当たった時に呼ばれる");
 }

 private void OnTriggerStay(Collider other)
 {
  Debug.Log("めり込んでいる最中に呼ばれる");
 }

 private void OnTriggerExit(Collider other)
 {
  Debug.Log("離れた時に呼ばれる");
 }
}
