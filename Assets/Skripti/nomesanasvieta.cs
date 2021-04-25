using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class nomesanasvieta : MonoBehaviour, IDropHandler
{


	private float vietasZrot;

	private float velkamaObjZrot;

	private float rotacijasStarpiba;

	private Vector2 vietasIzm;

	private Vector2 velkamaObjIzm;

	private float xIzmeruStarpiba;

	private float yIzmeruStarpiba;

	public objekti objektuSkripts;
	public void OnDrop(PointerEventData notikums)
	{
		if (notikums.pointerDrag != null)
		{
			if (notikums.pointerDrag.tag.Equals(tag))
			{
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				velkamaObjZrot = GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(vietasZrot - velkamaObjZrot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
				velkamaObjIzm = GetComponent<RectTransform>().localScale;
				xIzmeruStarpiba = Mathf.Abs(vietasIzm.x - velkamaObjIzm.x);
				yIzmeruStarpiba = Mathf.Abs(vietasIzm.y - velkamaObjIzm.y);

				if ((rotacijasStarpiba <= 9 || (rotacijasStarpiba >= 355 && rotacijasStarpiba <= 360)) && (double)xIzmeruStarpiba <= 0.15 && (double)yIzmeruStarpiba <= 0.15)
				{
					objektuSkripts.vaiIstajaVIeta = true;
					notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
					
					switch (notikums.pointerDrag.tag)
					{
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
						break;
					case "Atrie":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
						break;
					case "Buss":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
						break;
					case "Passarati":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
						break;
					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
						break;
					case "BMW":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
						break;
					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
						break;
					case "POPO":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
						break;
					case "DzeltensTraktors":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
						break;
					case "TraktorsArPiekabi":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
						break;
					case "Ugunsdzeseji":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[14]);
						break;
					}
					Debug.Log("Nedefinēts tags!");
				}
			}
			else
			{
				objektuSkripts.vaiIstajaVIeta = false;
				objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);
				switch (notikums.pointerDrag.tag)
				{
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrKoord;
					break;
				case "Atrie":
					objektuSkripts.atroMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atroKoord;
					break;
				case "Buss":
					objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
					break;
				case "Passarati":
					objektuSkripts.vieglamasina.GetComponent<RectTransform>().localPosition = objektuSkripts.vieglamasinaKoord;
					break;
				case "Cements":
					objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cemexKoord;
					break;
				case "BMW":
					objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
					break;
				case "Eskavators":
					objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskavatorsKoord;
					break;
				case "POPO":
					objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.policijaKoord;
					break;
				case "DzeltensTraktors":
					objektuSkripts.dzeltenaisTraktors.GetComponent<RectTransform>().localPosition = objektuSkripts.dzTraktorsKoord;
					break;
				case "TraktorsArPiekabi":
					objektuSkripts.traktorsArPiekabi.GetComponent<RectTransform>().localPosition = objektuSkripts.tArPiekabiKoord;
					break;
				case "Ugunsdzeseji":
					objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejiKoord;
					break;
				default:
					Debug.Log("Objektam nav noteikta pārvietošanas vieta!");
					break;
				}
			}
		}
	}
}
