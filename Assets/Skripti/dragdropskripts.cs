using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class dragdropskripts : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	
	public objekti objektuSkripts;

	//public beigaspele uzvarasNoteicejaSkripts;

	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;
	
	private void Awake()
	{
		kanvasGrupa = GetComponent<CanvasGroup>();
		velkObjRectTransf = GetComponent<RectTransform>();
	}

	
	public void OnPointerDown(PointerEventData notikums)
	{
		Debug.Log("Uzklikšķināts uz velkamā objekta");
	}

	
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log("Uzsākta vilkšana");
		objektuSkripts.pedejaisVilktais = null;
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}

	
	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek vilkšana");
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
		
	}

	
	public void OnEndDrag(PointerEventData notikums)
	{
		objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
		Debug.Log("Pēdējais vilktais objekts " + objektuSkripts.pedejaisVilktais);
		Debug.Log("Beigta vilkšana");
		kanvasGrupa.alpha = 1f;
		if (objektuSkripts.vaiIstajaVIeta == false)
		{
			kanvasGrupa.blocksRaycasts = true;
		}
		else
		{
			objektuSkripts.pedejaisVilktais = null;
		//	pareiziNomestoSkaits++;
		}
		objektuSkripts.vaiIstajaVIeta = false;
	}
	//public int pareiziNomestoSkaits;
}
