using UnityEngine;
using TMPro;

public class StartController : MonoBehaviour {
    FoxController m_foxController;
    [SerializeField]
    TextMeshProUGUI m_Console;

    string[] m_StartMessage;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        m_foxController = GameObject.Find("狐").GetComponent<FoxController>();
        m_foxController.enabled = false;
        m_StartMessage = new string[]{"\r\n",
"\r\n",
"■■■■■■　　　　　　　　　　　　　　　　　　　　　　　　　■■■■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■■\r\n",
"　■　　　■■　　　　　　　　　　　　　　　　　　　　　　■■　　　■■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■\r\n",
"　■　　　　■　　　　　　　　　　　　　　　　　　　　　　■　　　　　■　　　　　　　　　　　　　　　　　　　　　　　　　　　　■\r\n",
"　■　　　■■　　■■　　　■■　　　　■■■■■■　　■　　　　　　　　　■■　■■■　■■　　　■■　　　　■■■■　　　　■　■■■　　　　　　■■■　　　■■　■■■\r\n",
"　■■■■■　　　　■　　　　■　　　　■　　■■　　　■　　　　　　　　　　■■　　　　　■　　　　■　　　■　　　■■　　　■■　　　■　　　　■　　■■　　　■■\r\n",
"　■　　　■■　　　■　　　　■　　　■　　　　■　　　■　　　　　　　　　　■　　　　　　■　　　　■　　　■■　　　　　　　■　　　　■　　　■　　　　■　　　■\r\n",
"　■　　　　■　　　■　　　　■　　　■　　　　■　　　■　　　　　　　　　　■　　　　　　■　　　　■　　　　■■■■　　　　■　　　　■　　　■■■■■■　　　■\r\n",
"　■　　　　■　　　■　　　　■　　　■　　　　■　　　　■　　　　　　　　　■　　　　　　■　　　　■　　　　　　　　■　　　■　　　　■　　　■　　　　　　　　■\r\n",
"　■　　　■■　　　■　　　■■　　　　■　　■■　　　　■■　　　■■　　　■　　　　　　■　　　■■　　　■　　　　■　　　■　　　　■　　　　■　　　■　　　■\r\n",
"■■■■■■　　　　　■■■　■■　　　■■■■■　　　　　　■■■■　　　■■■　　　　　　■■■　■■　　■■■■■　　　■■■　　■■■　　　　■■■　　　■■■\r\n",
"　　　　　　　　　　　　　　　　　　　　　　　　■\r\n",
"　　　　　　　　　　　　　　　　　　　■■　　　■\r\n",
"　　　　　　　　　　　　　　　　　　　■■　　■\r\n",
"　　　　　　　　　　　　　　　　　　　　■■■\r\n",
"\r\n",
"\r\n",
"\r\n",
"\r\n",
"\r\n",
" 　　　　　　　＋──────────────＋　　　　　　　＋──────────────＋\r\n",
" 　　　　　　　│　　　　　　　　　　　　　　│　　　　　　　│　　　　　　　　　　　　　　│\r\n",
" 　　　　　　　│　　　　　スタート　　　　　│　　　　　　　│　　　チュートリアル　　　　│\r\n",
"　 　　　　　　│　　　　　　　　　　　　　　│　　　　　　　│　　　　　　　　　　　　　　│\r\n",
" 　　　　　　　＋──────────────＋　　　　　　　＋──────────────＋\r\n",
"\r\n",
"\r\n",
"\r\n",
"\r\n",
"\r\n",
"PS C:\\Users\\PC_User>　" };

        m_Console.text = "";
        foreach (string text in m_StartMessage) {
            Debug.Log(text);
            m_Console.text += text;
        }
        //m_Console.text = "test";

        Debug.Log("StartController Start");
        Time.timeScale = 0f;
    }

    public void DownStartButton() {
        m_foxController.enabled = true;
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
