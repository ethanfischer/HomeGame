using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverer : MonoBehaviour, IPointerEnterHandler
{
	public Sprite Icon;
	public Image TargetImage;

	public void OnPointerEnter(PointerEventData eventData)
	{
		TargetImage.sprite = Icon;
	}
}
