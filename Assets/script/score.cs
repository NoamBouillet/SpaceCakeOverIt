using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score_text;
    private float score_int = 0f;
    // Update is called once per frame
    void Update() {
        score_int = player.position.y + 2;
        score_text.text = "Score:" + score_int.ToString("0");
    }
}
