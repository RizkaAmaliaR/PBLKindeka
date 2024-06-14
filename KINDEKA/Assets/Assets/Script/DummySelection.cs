using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DummySelection : MonoBehaviour
{
    public Button langButton;
    public Button nikoButton;
    public Button tikoButton;

    public GameObject dummyLang;
    public GameObject dummyNiko;
    public GameObject dummyTiko;

    private int playerStars = 20;  // Jumlah bintang awal

    void Start()
    {
        langButton.onClick.AddListener(() => SelectDummy("Lang"));
        nikoButton.onClick.AddListener(() => SelectDummy("Niko"));
        tikoButton.onClick.AddListener(() => SelectDummy("Tiko"));
    }

    void SelectDummy(string dummy)
    {
        if (playerStars >= 5)
        {
            playerStars -= 5;
            if (CheckCorrectDummy(dummy))
            {
                // Lanjutkan ke storyline/level berikutnya
                Debug.Log("Benar! Lanjut ke level berikutnya.");
                SceneManager.LoadScene("NextLevelSceneName");  // Ganti dengan nama scene level berikutnya
            }
            else
            {
                // Salah memilih, kembali ke gameplay level 2
                Debug.Log("Salah! Kembali ke level 2.");
                // Implementasikan logika untuk kembali ke gameplay level 2
            }
        }
        else
        {
            Debug.Log("Tidak cukup bintang untuk memilih.");
        }
    }

    bool CheckCorrectDummy(string selectedDummy)
    {
        // Logika untuk memeriksa apakah dummy yang dipilih adalah pelaku
        string correctDummy = "Lang"; // Gantilah dengan logika yang sesuai
        return selectedDummy == correctDummy;
    }
} 
