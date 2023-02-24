using UnityEngine;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    public Text text;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "test";
        button.onClick.AddListener(() => 
        {
            Debug.Log("OnClock Button");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
