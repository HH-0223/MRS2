using UnityEngine;
using UnityEngine.UI;
public class Example : MonoBehaviour
{
    public Sprite newSprite;
    private Image image;
    void Start()
    {
        // SpriteRenderer�R���|�[�l���g���擾���܂�
        image = GetComponent<Image>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite;
        }
    }
}