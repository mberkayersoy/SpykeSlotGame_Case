using UnityEngine;

namespace MyExtensions.EventChannels
{
    /// <summary>
    /// This is a ScriptableObject-based event that takes an integer as a payload.
    /// </summary> 
    [CreateAssetMenu(menuName = "Events/Int EventChannel", fileName = "IntEventChannel")]
    public class IntEventChannelSO : GenericEventChannelSO<int>
    {
    }

}