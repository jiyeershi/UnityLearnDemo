// using UnityEngine;  
// using System.Collections;  
// using UnityEngine.UI;  
// using UnityEngine.EventSystems;  
// public class UIEventListener : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler  
// {  
//    
// /// <summary>  
// /// 定义事件代理  
// /// </summary>  
// /// <param name="gb"></param>  
// public delegate void UIEventProxy(GameObject gb);  
//    
// /// <summary>  
// /// 鼠标点击事件  
// /// </summary>  
// public event UIEventProxy OnClick;  
//    
// /// <summary>  
// /// 鼠标进入事件  
// /// </summary>  
// public event UIEventProxy OnMouseEnter;  
//    
// /// <summary>  
// /// 鼠标滑出事件  
// /// </summary>  
// public event UIEventProxy OnMouseExit;  
//    
// public void OnPointerClick(PointerEventData eventData)  
// {  
// if (OnClick != null)  
// OnClick(this.gameObject);  
// }  
//    
// public void OnPointerEnter(PointerEventData eventData)  
// {  
// if (OnMouseEnter != null)  
// OnMouseEnter(this.gameObject);  
// }  
//    
// public void OnPointerExit(PointerEventData eventData)  
// {  
// if (OnMouseExit != null)  
// OnMouseExit(this.gameObject);  
// }  
// }  

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class EventTriggerListener : UnityEngine.EventSystems.EventTrigger{
	public delegate void VoidDelegate (GameObject go);
	public VoidDelegate onClick;
	public VoidDelegate onDown;
	public VoidDelegate onEnter;
	public VoidDelegate onExit;
	public VoidDelegate onUp;
	public VoidDelegate onSelect;
	public VoidDelegate onUpdateSelect;
 
	static public EventTriggerListener Get (GameObject go)
	{
		EventTriggerListener listener = go.GetComponent<EventTriggerListener>();
		if (listener == null) listener = go.AddComponent<EventTriggerListener>();
		return listener;
	}
	public override void OnPointerClick(PointerEventData eventData)
	{
		if(onClick != null) 	onClick(gameObject);
	}
	public override void OnPointerDown (PointerEventData eventData){
		if(onDown != null) onDown(gameObject);
	}
	public override void OnPointerEnter (PointerEventData eventData){
		if(onEnter != null) onEnter(gameObject);
	}
	public override void OnPointerExit (PointerEventData eventData){
		if(onExit != null) onExit(gameObject);
	}
	public override void OnPointerUp (PointerEventData eventData){
		if(onUp != null) onUp(gameObject);
	}
	public override void OnSelect (BaseEventData eventData){
		if(onSelect != null) onSelect(gameObject);
	}
	public override void OnUpdateSelected (BaseEventData eventData){
		if(onUpdateSelect != null) onUpdateSelect(gameObject);
	}
}