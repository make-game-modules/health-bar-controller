using UnityEngine;
/// <summary>
/// HealthBarController �����ڹ�����Ϸ��ɫ��Ѫ����
/// ����Ӧ���ص����� CharacterHealthController �������Ϸ�����ϡ�
/// ��Ҫ�� Unity �༭����ָ��Ѫ����Ѫ�۵�Ԥ�Ƽ���
/// ���ཫ��̬����Ѫ���Ĵ�С���Է�ӳ��ɫ�ĵ�ǰѪ����
/// </summary>
[RequireComponent(typeof(CharacterHealthController))]
public class HealthBarController : MonoBehaviour
{
    public GameObject healthBar;    // Ѫ��Ԥ�Ƽ�
    public GameObject healthSlot;   // Ѫ��Ԥ�Ƽ�

    private CharacterHealthController character;  // ��ɫ�� CharacterHealthController ���

    /// <summary>
    /// ����Ϸ��ʼʱ��ʼ�����á�
    /// </summary>
    void Start()
    {
        // ��ȡ��ɫ�� CharacterHealthController ���
        character = GetComponent<CharacterHealthController>();
    }

    /// <summary>
    /// ÿ֡����Ѫ���Ĵ�С��
    /// </summary>
    void Update()
    {
        // ��ȡ��ɫ��ǰ��Ѫ���ٷֱ�
        float healthPercentage = character.GetHealthPercentage();

        // ��̬�ظı�Ѫ���ĳߴ�
        healthBar.transform.localScale = new Vector3(healthPercentage, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
