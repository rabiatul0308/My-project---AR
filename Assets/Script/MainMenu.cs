using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Play");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

	public void Languange()
	{
		SceneManager.LoadScene("Languange");
	}

	public void Ringkasan()
	{
		SceneManager.LoadScene("Ringkasan");
	}

	public void Developer()
	{
		SceneManager.LoadScene("Developer");
	}

	public void Panduan()
	{
		SceneManager.LoadScene("Panduan");
	}

	public void Deskripsi()
	{
		SceneManager.LoadScene("Deskripsi");
	}


	public void Exit()
    {
        Application.Quit();
    }
}
