using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class scoreGameOver : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    private float score_int = 0f;
    // Update is called once per frame
    void Update() {
        score_int = PlayerPrefs.GetInt("PlayerScore", 0);
        score_text.text = "Score:" + score_int.ToString("0");
    }
}
