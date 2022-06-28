using UnityEngine;

namespace Quartzified
{
    public static class Gizmos
    {
        #region Improvements

        public static void DrawWireCube(Vector3 center, Vector3 size, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = UnityEngine.Gizmos.matrix;
            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(center, rotation, size);
            UnityEngine.Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawWireSphere(Vector3 center, float radius, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = UnityEngine.Gizmos.matrix;
            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            UnityEngine.Gizmos.DrawWireSphere(center, radius);
            UnityEngine.Gizmos.matrix = old;
        }

        #endregion

        #region New Shapes

        public static void DrawWireArc(Vector3 center, float radius, float angle, int segments = 20, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = UnityEngine.Gizmos.matrix;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            Vector3 from = Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad));
                UnityEngine.Gizmos.DrawLine(from, to);
                from = to;
            }

            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawWireArc(Vector3 center, float radius, float angle, int segments, Quaternion rotation, Vector3 centerOfRotation)
        {

            Matrix4x4 old = UnityEngine.Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(centerOfRotation, rotation, Vector3.one);
            Vector3 deltaTranslation = centerOfRotation - center;
            Vector3 from = deltaTranslation + Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad)) + deltaTranslation;
                UnityEngine.Gizmos.DrawLine(from, to);
                from = to;
            }

            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawWireArc(Matrix4x4 matrix, float radius, float angle, int segments)
        {
            Matrix4x4 old = UnityEngine.Gizmos.matrix;

            UnityEngine.Gizmos.matrix = matrix;
            Vector3 from = Vector3.forward * radius;
            int step = Mathf.RoundToInt(angle / segments);

            for (int i = 0; i <= angle; i += step)
            {
                Vector3 to = new Vector3(radius * Mathf.Sin(i * Mathf.Deg2Rad), 0, radius * Mathf.Cos(i * Mathf.Deg2Rad));
                UnityEngine.Gizmos.DrawLine(from, to);
                from = to;
            }

            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawWireCircle(Vector3 center, float radius, int segments = 20, Quaternion rotation = default(Quaternion))
        {
            DrawWireArc(center, radius, 360, segments, rotation);
        }

        public static void DrawWireCylinder(Vector3 center, float radius, float height, Quaternion rotation = default(Quaternion))
        {
            Matrix4x4 old = UnityEngine.Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            float half = height / 2;

            UnityEngine.Gizmos.DrawLine(Vector3.right * radius - Vector3.up * half, Vector3.right * radius + Vector3.up * half);
            UnityEngine.Gizmos.DrawLine(-Vector3.right * radius - Vector3.up * half, -Vector3.right * radius + Vector3.up * half);
            UnityEngine.Gizmos.DrawLine(Vector3.forward * radius - Vector3.up * half, Vector3.forward * radius + Vector3.up * half);
            UnityEngine.Gizmos.DrawLine(-Vector3.forward * radius - Vector3.up * half, -Vector3.forward * radius + Vector3.up * half);

            DrawWireArc(center + Vector3.up * half, radius, 360, 20, rotation, center);
            DrawWireArc(center + Vector3.down * half, radius, 360, 20, rotation, center);

            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawWireCapsule(Vector3 center, float radius, float height, Quaternion rotation = default(Quaternion))
        {
            var old = UnityEngine.Gizmos.matrix;

            if (rotation.Equals(default(Quaternion)))
                rotation = Quaternion.identity;

            UnityEngine.Gizmos.matrix = Matrix4x4.TRS(center, rotation, Vector3.one);
            float half = height / 2 - radius;

            DrawWireCylinder(center, radius, height - radius * 2, rotation);

            Matrix4x4 mat = Matrix4x4.Translate(center + rotation * Vector3.up * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);
            mat = Matrix4x4.Translate(center + rotation * Vector3.up * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.up) * Quaternion.AngleAxis(90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);

            mat = Matrix4x4.Translate(center + rotation * Vector3.down * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(90, Vector3.up) * Quaternion.AngleAxis(-90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);
            mat = Matrix4x4.Translate(center + rotation * Vector3.down * half) * Matrix4x4.Rotate(rotation * Quaternion.AngleAxis(-90, Vector3.forward));
            DrawWireArc(mat, radius, 180, 20);

            UnityEngine.Gizmos.matrix = old;
        }

        public static void DrawArrow(Vector3 from, Vector3 to, float arrowHeadLength = 0.2f, float arrowHeadAngle = 20f)
        {
            UnityEngine.Gizmos.DrawLine(from, to);
            Vector3 direction = to - from;

            Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
            Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);

            UnityEngine.Gizmos.DrawLine(to, to + right * arrowHeadLength);
            UnityEngine.Gizmos.DrawLine(to, to + left * arrowHeadLength);
        }

        #endregion
    }
}


