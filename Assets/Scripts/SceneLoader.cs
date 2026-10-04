using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadOnboarding()
    {
        SceneManager.LoadScene("02_Onboarding");
    }
}