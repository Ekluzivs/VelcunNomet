using System;
using UnityEngine;

public class objekti : MonoBehaviour
{
	
	public GameObject atkritumuMasina;
	
	public GameObject atroMasina;

	public GameObject eskavators;

	public GameObject policija;

	public GameObject dzeltenaisTraktors;

	public GameObject traktorsArPiekabi;

	public GameObject autobuss;

	public GameObject vieglamasina;

	public GameObject cementaMasina;

	public GameObject e46;

	public GameObject ugunsdzeseji;

	[HideInInspector]
	public Vector2 bussKoord;

	[HideInInspector]
	public Vector2 vieglamasinaKoord;

	[HideInInspector]
	public Vector2 cemexKoord;

	[HideInInspector]
	public Vector2 e46Koord;

	[HideInInspector]
	public Vector2 eskavatorsKoord;
	
	[HideInInspector]
	public Vector2 atkrKoord;

	[HideInInspector]
	public Vector2 atroKoord;

	[HideInInspector]
	public Vector2 policijaKoord;

	[HideInInspector]
	public Vector2 dzTraktorsKoord;

	[HideInInspector]
	public Vector2 tArPiekabiKoord;

	[HideInInspector]
	public bool vaiIstajaVIeta;

	public GameObject pedejaisVilktais;

	[HideInInspector]
	public Vector2 ugunsdzesejiKoord;

	public Canvas kanva;

	public AudioSource skanasAvots;

	public AudioClip[] skanaKoAtskanot;
	private void Awake()
	{
		atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
		vieglamasinaKoord = vieglamasina.GetComponent<RectTransform>().localPosition;
		cemexKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		eskavatorsKoord = eskavators.GetComponent<RectTransform>().localPosition;
		policijaKoord = policija.GetComponent<RectTransform>().localPosition;
		dzTraktorsKoord = dzeltenaisTraktors.GetComponent<RectTransform>().localPosition;
		tArPiekabiKoord = traktorsArPiekabi.GetComponent<RectTransform>().localPosition;
		ugunsdzesejiKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
	}

}
