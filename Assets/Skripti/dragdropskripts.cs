using System;
using UnityEngine;
using UnityEngine.EventSystems;


public class dragdropskripts : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

	private void Awake()
	{
		kanvasGrupa = GetComponent<CanvasGroup>();
		velkObjRectTransf = GetComponent<RectTransform>();
	}


	public void OnPointerDown(PointerEventData notikums)
	{
		Debug.Log("Uzklikšķināts uz velkamā objekta");
	}


	public void OnBeginDrag(PointerEventData notikums)
	{
		objektuSkripts.pedejaisVilktais = null;
		Debug.Log("Uzsākta vilkšana");
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
		
	}

	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek vilkšana");
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
		velkObjRectTransf.position = new Vector3(Mathf.Clamp(velkObjRectTransf.position.x, 10f, 1270f), Mathf.Clamp(velkObjRectTransf.position.y, 10f, 590f), velkObjRectTransf.position.z);
	}



	public void OnEndDrag(PointerEventData notikums)
	{
		objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
		Debug.Log("Pēdējais vilktais objekts " + objektuSkripts.pedejaisVilktais);
		Debug.Log("Beigta vilkšana");
		kanvasGrupa.alpha = 1f;
		if (!objektuSkripts.vaiIstajaVIeta)
		{
			kanvasGrupa.blocksRaycasts = true;
			objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[18]);
		}
		else
		{
			objektuSkripts.pedejaisVilktais = null;
			//uzvarasNoteicejaSkripts.pareiziNomestie();
		}
		objektuSkripts.vaiIstajaVIeta = false;
	}

	public objekti objektuSkripts;

	//public UzvarasNoteicejs uzvarasNoteicejaSkripts;

	private CanvasGroup kanvasGrupa;

	private RectTransform velkObjRectTransf;
}
