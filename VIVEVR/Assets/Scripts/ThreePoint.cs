using UnityEngine;
using UnityEngine.UI;

public class ThreePoint : MonoBehaviour
{
    private Text textArea;

    /// <summary>
    /// 進入三分球區域：true 進入、false 離開
    /// </summary>
    public bool inThreePoint;

    private void Start()
    {
        textArea = GameObject.Find("區域").GetComponent<Text>();
    }

    /// <summary>
    /// Enter 物件進入時
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        // 如果碰到的物件名稱為 "HeadCollider"
        if (other.name == "HeadCollider")
        {
            inThreePoint = true;
            textArea.text = "區域：三分球";
        }
    }

    /// <summary>
    /// Exit 物件離開時
    /// </summary>
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            inThreePoint = false;
            textArea.text = "區域：兩分球";
        }
    }
}
