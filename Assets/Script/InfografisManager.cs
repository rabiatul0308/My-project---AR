using UnityEngine;
using UnityEngine.UI;

public class InfografisManager : MonoBehaviour
{
	public Image tempatGambar;     // Kotak Image di Canvas
	public Sprite[] daftarGambar;  // Daftar 3 gambar (8, 9, 10)

	private int nomorSekarang = 0;

	void Start()
	{
		if (daftarGambar.Length > 0)
		{
			tempatGambar.sprite = daftarGambar[0];
		}
	}

	public void KlikNext()
	{
		nomorSekarang++;

		if (nomorSekarang >= daftarGambar.Length)
		{
			nomorSekarang = 0;
		}

		tempatGambar.sprite = daftarGambar[nomorSekarang];
	}
}