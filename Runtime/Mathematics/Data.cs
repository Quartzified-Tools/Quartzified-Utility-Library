
namespace Quartzified.Mathematics.Data
{
    public static class Data
    {
        public static string ConvertFromBytes(long _byte)
        {
            string final;
            if (_byte >= 1E+09f)
            {
                final = (_byte / 1E+09f).ToString("F2") + " GB";
            }
            else if (_byte >= 1000000f)
            {
                final = (_byte / 1000000f).ToString("F2") + " MB";
            }
            else if (_byte >= 1000f)
            {
                final = (_byte / 1000f).ToString("F2") + " KB";
            }
            else
            {
                final = _byte.ToString() + " B";
            }

            return final;
        }
        public static string ConvertFromBytes(ulong _byte)
        {
            string final;
            if (_byte >= 1E+09f)
            {
                final = (_byte / 1E+09f).ToString("F2") + " GB";
            }
            else if (_byte >= 1000000f)
            {
                final = (_byte / 1000000f).ToString("F2") + " MB";
            }
            else if (_byte >= 1000f)
            {
                final = (_byte / 1000f).ToString("F2") + " KB";
            }
            else
            {
                final = _byte.ToString() + " B";
            }

            return final;
        }
    }
}
