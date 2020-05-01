using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;   // 引用 VR 互動 API

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textBallCount;
    [Header("分數")]
    public Text textScore;

    private int ballCount = 5;
    private int score;

    public void UseBall(GameObject ball)
    {
        // 刪除(球.取得元件<丟擲>())
        // 刪除(球.取得元件<互動>())
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        // 數量遞減
        ballCount--;
        // 更新文字
        textBallCount.text = "籃球數量：" + ballCount + " / 5";
    }

    private void OnTriggerEnter(Collider other)
    {
        // 分數遞增2
        score+=2;
        // 更新文字
        textScore.text = "分數：" + score;
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
