using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text uiNowItemCount;
    public Text uiStateItemCount;

    int stageItemCount = 6;
    string sceneName;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;

        uiNowItemCount.text = "0";
        uiStateItemCount.text = stageItemCount.ToString();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetStageItemCount()
    {
        return stageItemCount;
    }

    public void SetStageItemCount(int nStageItemCount)
    {
        stageItemCount = nStageItemCount;
    }

    public string GetSceneName()
    {
        return sceneName;
    }

    public void SetSceneName(string nSceneName)
    {
        sceneName = nSceneName;
    }

    public void setUiNowItemCount(int nItemCount)
    {
        uiNowItemCount.text = nItemCount.ToString();
    }

}
