using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

/*
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif
*/

namespace Quartzified.Events
{
    public static class EventUtility
    {
        public static void SetListener(this UnityEvent uEvent, UnityAction call)
        {
            uEvent.RemoveAllListeners();
            uEvent.AddListener(call);
        }

        public static void SetListener<T>(this UnityEvent<T> uEvent, UnityAction<T> call)
        {
            uEvent.RemoveAllListeners();
            uEvent.AddListener(call);
        }

        public static void DeselectCarefully()
        {
/*#if ENABLE_INPUT_SYSTEM
            Mouse mouse = Mouse.current;
            if (mouse != null)
            {
                if (!mouse.leftButton.wasPressedThisFrame &&
                    !mouse.rightButton.wasPressedThisFrame &&
                    !mouse.middleButton.wasPressedThisFrame)
                {
                    EventSystem.current.SetSelectedGameObject(null);
                }
            }
#elif ENABLE_LEGACY_INPUT_MANAGER

#endif*/
                if (!Input.GetMouseButton(0) &&
                !Input.GetMouseButton(1) &&
                !Input.GetMouseButton(2))
            {
                EventSystem.current.SetSelectedGameObject(null);
            }
        }

        public static bool IsCursorOverUserInterface()
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return true;

            for (int i = 0; i < Input.touchCount; ++i)
                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
                    return true;

            return GUIUtility.hotControl != 0;
        }
    }
}
