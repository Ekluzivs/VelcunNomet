using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000004 RID: 4
public class nomesanasvieta : MonoBehaviour, IEventSystemHandler, IDropHandler
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002318 File Offset: 0x00000518
	public void OnDrop(PointerEventData notikums)
	{
		if (notikums.pointerDrag != null)
		{
			if (notikums.pointerDrag.tag.Equals(base.tag))
			{
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				velkamaObjZrot = base.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(vietasZrot - velkamaObjZrot);
				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
				Debug.Log("Nomešanas vietas izmērs: " + vietasIzm);
				velkamaObjIzm = base.GetComponent<RectTransform>().localScale;
				Debug.Log("Velkamā objekta izmērs: " + velkamaObjIzm);
				xIzmeruStarpiba = Mathf.Abs(vietasIzm.x - velkamaObjIzm.x);
				yIzmeruStarpiba = Mathf.Abs(vietasIzm.y - velkamaObjIzm.y);
				Debug.Log(string.Concat(new object[]
				{
					"Izmēru starpība x:",
					xIzmeruStarpiba,
					" y:",
					yIzmeruStarpiba
				}));
				if ((rotacijasStarpiba <= 5f || (rotacijasStarpiba >= 355f && rotacijasStarpiba <= 360f)) && (double)xIzmeruStarpiba <= 0.08 && (double)yIzmeruStarpiba <= 0.08)
				{
					Debug.Log("Nomests pareizajā vietā!");
					objektuSkripts.vaiIstajaVIeta = true;
					notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition = base.GetComponent<RectTransform>().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform>().localRotation = base.GetComponent<RectTransform>().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform>().localScale = base.GetComponent<RectTransform>().localScale;
					string tag = notikums.pointerDrag.tag;
					switch (tag)
					{
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
						goto IL_559;
					case "Atrie":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
						goto IL_559;
					case "Buss":
						objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
						goto IL_559;
					}
					Debug.Log("Nedefinēts tags!");
				}
				IL_559:;
			}
			else
			{
				objektuSkripts.vaiIstajaVIeta = false;
				objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);
				string tag = notikums.pointerDrag.tag;
				switch (tag)
				{
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrKoord;
					return;
				case "Atrie":
					objektuSkripts.atroMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atroKoord;
					return;
				case "Buss":
					objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.bussKoord;
					return;
				}
				Debug.Log("Objektam nav noteikta pārvietošanas vieta!");
			}
		}
	}

	// Token: 0x04000005 RID: 5
	private float vietasZrot;

	// Token: 0x04000006 RID: 6
	private float velkamaObjZrot;

	// Token: 0x04000007 RID: 7
	private float rotacijasStarpiba;

	// Token: 0x04000008 RID: 8
	private Vector3 vietasIzm;

	// Token: 0x04000009 RID: 9
	private Vector3 velkamaObjIzm;

	// Token: 0x0400000A RID: 10
	private float xIzmeruStarpiba;

	// Token: 0x0400000B RID: 11
	private float yIzmeruStarpiba;

	// Token: 0x0400000C RID: 12
	public objekti objektuSkripts;
}