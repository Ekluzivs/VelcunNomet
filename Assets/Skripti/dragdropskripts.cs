using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000003 RID: 3
public class dradropskripts : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	// Token: 0x06000004 RID: 4 RVA: 0x0000210C File Offset: 0x0000030C
	private void Awake()
	{
		this.kanvasGrupa = base.GetComponent<CanvasGroup>();
		this.velkObjRectTransf = base.GetComponent<RectTransform>();
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002128 File Offset: 0x00000328
	public void OnPointerDown(PointerEventData notikums)
	{
		Debug.Log("Uzklikšķināts uz velkamā objekta");
		this.objektuSkripts.skanasAvots.PlayOneShot(this.objektuSkripts.skanaKoAtskanot[17]);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002160 File Offset: 0x00000360
	public void OnBeginDrag(PointerEventData notikums)
	{
		this.objektuSkripts.pedejaisVilktais = null;
		Debug.Log("Uzsākta vilkšana");
		this.kanvasGrupa.alpha = 0.6f;
		this.kanvasGrupa.blocksRaycasts = false;
		this.velkObjRectTransf.SetSiblingIndex(29);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021AC File Offset: 0x000003AC
	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek vilkšana");
		this.velkObjRectTransf.anchoredPosition += notikums.delta / this.objektuSkripts.kanva.scaleFactor;
		this.velkObjRectTransf.position = new Vector3(Mathf.Clamp(this.velkObjRectTransf.position.x, 10f, 1270f), Mathf.Clamp(this.velkObjRectTransf.position.y, 10f, 590f), this.velkObjRectTransf.position.z);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000225C File Offset: 0x0000045C
	public void OnEndDrag(PointerEventData notikums)
	{
		this.objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
		Debug.Log("Pēdējais vilktais objekts " + this.objektuSkripts.pedejaisVilktais);
		Debug.Log("Beigta vilkšana");
		this.kanvasGrupa.alpha = 1f;
		if (!this.objektuSkripts.vaiIstajaVIeta)
		{
			this.kanvasGrupa.blocksRaycasts = true;
			this.objektuSkripts.skanasAvots.PlayOneShot(this.objektuSkripts.skanaKoAtskanot[18]);
		}
		else
		{
			this.objektuSkripts.pedejaisVilktais = null;
			this.uzvarasNoteicejaSkripts.pareiziNomestie();
		}
		this.objektuSkripts.vaiIstajaVIeta = false;
	}

	// Token: 0x04000001 RID: 1
	public Objekti objektuSkripts;

	// Token: 0x04000002 RID: 2
	public UzvarasNoteicejs uzvarasNoteicejaSkripts;

	// Token: 0x04000003 RID: 3
	private CanvasGroup kanvasGrupa;

	// Token: 0x04000004 RID: 4
	private RectTransform velkObjRectTransf;
}
