using UnityEngine;

namespace MyExtensions.EventChannels
{
    /// <summary>
    /// A Scriptable Object-based event that passes a float as a payload.
    /// </summary>
    [CreateAssetMenu(fileName = "FloatEventChannel", menuName = "Events/FloatEventChannelSO")]
    public class FloatEventChannelSO : GenericEventChannelSO<float>
    {

    }
}