using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Quartzified.Mathematics.Raycasts
{
    public static class RaycastUtility
    {
        public static RaycastHit2D Raycast2DWithout(Ray ray, GameObject ignore)
        {
            Dictionary<Transform, int> backups = new Dictionary<Transform, int>();

            foreach (Transform tf in ignore.GetComponentsInChildren<Transform>(true))
            {
                backups[tf] = tf.gameObject.layer;
                tf.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
            }

            RaycastHit2D result = Physics2D.GetRayIntersection(ray);

            foreach (KeyValuePair<Transform, int> kvp in backups)
                kvp.Key.gameObject.layer = kvp.Value;

            return result;
        }

        static Dictionary<Transform, int> castBackups = new Dictionary<Transform, int>();
        public static bool RaycastWithoutExtended(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, GameObject ignore, int layerMask = Physics.DefaultRaycastLayers)
        {
            // Remember Layers
            castBackups.Clear();

            // Set all to ignore raycast
            foreach (Transform tf in ignore.GetComponentsInChildren<Transform>(true))
            {
                castBackups[tf] = tf.gameObject.layer;
                tf.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
            }

            // Raycast
            bool result = Physics.Raycast(origin, direction, out hit, maxDistance, layerMask);

            // Restore Layers
            foreach (KeyValuePair<Transform, int> kvp in castBackups)
                kvp.Key.gameObject.layer = kvp.Value;

            return result;
        }

        public static bool RaycastWithout(Ray ray, out RaycastHit hit, GameObject ignore)
        {
            Dictionary<Transform, int> backups = new Dictionary<Transform, int>();

            foreach (Transform tf in ignore.GetComponentsInChildren<Transform>(true))
            {
                backups[tf] = tf.gameObject.layer;
                tf.gameObject.layer = LayerMask.NameToLayer("Ignore Raycast");
            }

            bool result = Physics.Raycast(ray, out hit);

            foreach (KeyValuePair<Transform, int> kvp in backups)
                kvp.Key.gameObject.layer = kvp.Value;

            return result;
        }

        #region UI Raycasting

        public static RaycastResult RaycastUI(Vector2 screenPos)
        {
            List<RaycastResult> hitResults = CastIntoUI(ScreenPosToPointerData(screenPos));

            return hitResults.Count > 0 ? hitResults[0] : new RaycastResult();
        }

        public static bool IsPointerOverUI(Vector2 screenPos)
        {
            List<RaycastResult> hitResults = CastIntoUI(ScreenPosToPointerData(screenPos));
            if(hitResults.Count > 0)
            {
                GameObject first = hitResults[0].gameObject;
                if (first != null && first.layer == LayerMask.NameToLayer("UI"))
                {
                    return true;
                }
            }

            return false;
        }

        static List<RaycastResult> CastIntoUI(PointerEventData pointerData)
        {
            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            return results;
        }

        static PointerEventData ScreenPosToPointerData(Vector2 screenPos) => new(EventSystem.current) { position = screenPos };

        #endregion
    }
}
