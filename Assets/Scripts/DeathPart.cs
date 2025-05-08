using UnityEngine;

public class DeathPart : MonoBehaviour
{
    private void OnEnable() {
        Debug.Log("OnEnable called");
        GetComponent<Renderer>().material.color = Color.red;
    }
}
