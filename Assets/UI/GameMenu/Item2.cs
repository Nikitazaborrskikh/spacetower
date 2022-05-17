using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item2 : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject _item;
    private float _scaleChange = 1.2f;

    public static Transform DragFrom;

    [SerializeField] private GameObject _image;

    //private void Start()
    //{
    //    _image.SetActive(false);
    //}

    public void OnPointerDown(PointerEventData eventData)
    {
       
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.SetActive(true);
        _item.transform.localScale *= _scaleChange;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.SetActive(false);
        _item.transform.localScale = new Vector3(1f, 1f);
    }
}
