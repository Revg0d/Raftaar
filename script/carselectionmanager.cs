using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class carselectionmanager : MonoBehaviour
{
    public GameObject[] cars;
    public int currentcar;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void nextcar()
    {
        currentcar += 1;
        for (int i  =0; i< cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[currentcar].SetActive(true);
        }
   
    }
    public void previouscar()
    {
        currentcar -= 1;
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[currentcar].SetActive(true);
        }
    }
    public void selectcar()
    {
        PlayerPrefs.SetInt("selectedcar", currentcar);
        SceneManager.LoadScene("raftaar");
    }
    public void backtomenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
