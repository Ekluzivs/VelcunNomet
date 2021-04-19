using System;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class objektutransformesana : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x00002DCC File Offset: 0x00000FCC
	private void Update()
	{
		if (this.objektuSkripts.pedejaisVilktais != null)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0f, 0f, Time.deltaTime * 9f);
			}
			if (Input.GetKey(KeyCode.X))
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0f, 0f, -Time.deltaTime * 9f);
			}
			if (Input.GetKey(KeyCode.UpArrow) && this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y < 0.8f)
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector3(this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.001f, 1f);
			}
			if (Input.GetKey(KeyCode.DownArrow) && (double)this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y > 0.35)
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector3(this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.001f, 1f);
			}
			if (Input.GetKey(KeyCode.LeftArrow) && (double)this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x > 0.35)
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector3(this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f, this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y, 1f);
			}
			if (Input.GetKey(KeyCode.RightArrow) && (double)this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x < 0.9)
			{
				this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale = new Vector3(this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f, this.objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y, 1f);
			}
		}
	}

	// Token: 0x04000030 RID: 48
	public objekti objektuSkripts;
}
