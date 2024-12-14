using UnityEngine;

public class GetScore : MonoBehaviour
{
    private float score;
    void Update()
    {
        score = GameObject.FindGameObjectWithTag("Player").transform.position.y;
    }
}
