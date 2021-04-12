using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000005 RID: 5
public class objekti : MonoBehaviour
{
	private void Awake()
	{
		atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
	}

	// Token: 0x0400000F RID: 15
	public GameObject atkritumuMasina;
    public GameObject atroMasina;
	public GameObject autobuss;
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public Canvas kanva;

	// Token: 0x0400002C RID: 44
	public AudioSource skanasAvots;

	// Token: 0x0400002D RID: 45
	public AudioClip[] skanaKoAtskanot;

	// Token: 0x0400002E RID: 46
	[HideInInspector]
	public bool vaiIstajaVIeta;

	// Token: 0x0400002F RID: 47
	public GameObject pedejaisVilktais;
}
