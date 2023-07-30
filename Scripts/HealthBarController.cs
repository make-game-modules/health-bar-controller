using UnityEngine;
/// <summary>
/// HealthBarController 类用于管理游戏角色的血条。
/// 此类应挂载到具有 CharacterHealthController 组件的游戏对象上。
/// 需要在 Unity 编辑器中指定血条和血槽的预制件。
/// 此类将动态调整血条的大小，以反映角色的当前血量。
/// </summary>
[RequireComponent(typeof(CharacterHealthController))]
public class HealthBarController : MonoBehaviour
{
    public GameObject healthBar;    // 血条预制件
    public GameObject healthSlot;   // 血槽预制件

    private CharacterHealthController character;  // 角色的 CharacterHealthController 组件

    /// <summary>
    /// 在游戏开始时初始化引用。
    /// </summary>
    void Start()
    {
        // 获取角色的 CharacterHealthController 组件
        character = GetComponent<CharacterHealthController>();
    }

    /// <summary>
    /// 每帧更新血条的大小。
    /// </summary>
    void Update()
    {
        // 获取角色当前的血量百分比
        float healthPercentage = character.GetHealthPercentage();

        // 动态地改变血条的尺寸
        healthBar.transform.localScale = new Vector3(healthPercentage, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
