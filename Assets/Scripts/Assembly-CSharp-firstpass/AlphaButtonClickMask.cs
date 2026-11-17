using System;
using UnityEngine;
using UnityEngine.UI;

public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	protected Image _image;

	public void Start()
	{
		//IL_0036: Expected Obj, but got Unknown
		_image = ((Component)this).GetComponent<Image>();
		Texture2D texture = _image.sprite.texture;
		bool flag = false;
		if ((Object)(object)texture != (Object)null)
		{
			try
			{
				texture.GetPixels32();
			}
			catch (UnityException ex)
			{
				Debug.LogError((object)((Exception)ex).Message);
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			Debug.LogError((object)"This script need an Image with a readbale Texture2D to work.");
		}
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(((Graphic)_image).rectTransform, sp, eventCamera, ref val);
		Vector2 pivot = ((Graphic)_image).rectTransform.pivot;
		float x = pivot.x;
		float x2 = val.x;
		Rect rect = ((Graphic)_image).rectTransform.rect;
		float num = x + x2 / rect.width;
		float y = pivot.y;
		float y2 = val.y;
		rect = ((Graphic)_image).rectTransform.rect;
		Vector2 val2 = new Vector2(num, y + y2 / rect.height);
		rect = _image.sprite.rect;
		float x3 = rect.x;
		float x4 = val2.x;
		rect = _image.sprite.rect;
		float num2 = x3 + x4 * rect.width;
		rect = _image.sprite.rect;
		float y3 = rect.y;
		float y4 = val2.y;
		rect = _image.sprite.rect;
		Vector2 val3 = new Vector2(num2, y3 + y4 * rect.height);
		val3.x /= ((Texture)_image.sprite.texture).width;
		val3.y /= ((Texture)_image.sprite.texture).height;
		return _image.sprite.texture.GetPixelBilinear(val3.x, val3.y).a > 0.1f;
	}
}
