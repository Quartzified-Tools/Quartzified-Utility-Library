using UnityEditor;

namespace Quartzified.Editor.ViewSize
{
    public class ViewSizeTool
    {
        [MenuItem("Quartzified/Editor Utility/View Sizes/Clear/Android")]
        public static void ClearAndroid()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.Android);

            tool.Clear();

            EditorUtility.DisplayDialog("View Size Tool", "Successfully cleared all custom Android view Sizes!", "Good");
        }

        [MenuItem("Quartzified/Editor Utility/View Sizes/Clear/iOS")]
        public static void ClearIOS()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.iOS);

            tool.Clear();

            EditorUtility.DisplayDialog("View Size Tool", "Successfully cleared all custom iOS view Sizes!", "Good");
        }

        [MenuItem("Quartzified/Editor Utility/View Sizes/Generate/Android/Defaults (Portrait)")]
        public static void GenerateAndroidPortraitSizes()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.Android);

            tool.CastFixedSize("SG S7 (P)", 1440, 2560);
            tool.CastFixedSize("SG S8/9 (P)", 1440, 2960);
            tool.CastFixedSize("SG S10 (P)", 1440, 3040);
            tool.CastFixedSize("SG S22 (P)", 1080, 2340);
            tool.CastFixedSize("SG S22 Ultra (P)", 1440, 3088);

            tool.CastFixedSize("SG Z Flip 4 (P)", 1440, 2640);

            tool.CastFixedSize("Google Pixel 6 Pro (P)", 1440, 3120);

            EditorUtility.DisplayDialog("View Size Tool", "Successfully created Android portrait defaults! (Can be viewed when the current build platform is Android)", "Understood");
        }

        [MenuItem("Quartzified/Editor Utility/View Sizes/Generate/Android/Defaults (Landscape)")]
        public static void GenerateAndroidLandscapeSizes()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.Android);

            tool.CastFixedSize("SG S7 (L)", 2560, 1440);
            tool.CastFixedSize("SG S8/9 (L)", 2960, 1440);
            tool.CastFixedSize("SG S10 (L)", 3040, 1440);
            tool.CastFixedSize("SG S22 (L)", 2340, 1080);
            tool.CastFixedSize("SG S22 Ultra (L)", 3088, 1440);

            tool.CastFixedSize("SG Z Flip 4 (L)", 2640, 1440);

            tool.CastFixedSize("Google Pixel 6 Pro (L)", 3120, 1440);

            EditorUtility.DisplayDialog("View Size Tool", "Successfully created Android landscape defaults! (Can be viewed when the current build platform is Android)", "Understood");
        }

        [MenuItem("Quartzified/Editor Utility/View Sizes/Generate/IOS/Defaults (Portrait)")]
        public static void GenerateIOSPortraitSizes()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.iOS);

            tool.CastFixedSize("iPhone 7/8 (P)", 750, 1334);
            tool.CastFixedSize("iPhone 7+/8+ (P)", 1080, 1920);
            tool.CastFixedSize("iPhone X/XS (P)", 1125, 2436);
            tool.CastFixedSize("iPhone 11/XR (P)", 828, 1792);
            tool.CastFixedSize("iPhone 11 Pro (P)", 1125, 2436);
            tool.CastFixedSize("iPhone 12/13 (P)", 1170, 2532);
            tool.CastFixedSize("iPhone 12/13 Pro Max (P)", 1284, 2778);

            EditorUtility.DisplayDialog("View Size Tool", "Successfully created iOS portrait defaults! (Can be viewed when the current build platform is iOS)", "Understood");
        }

        [MenuItem("Quartzified/Editor Utility/View Sizes/Generate/IOS/Defaults (Landscape)")]
        public static void GenerateIOSLandscapeSizes()
        {
            ViewSizeGroupExtension tool = new ViewSizeGroupExtension(GameViewSizeGroupType.iOS);

            tool.CastFixedSize("iPhone 7/8 (P)", 1334, 750);
            tool.CastFixedSize("iPhone 7+/8+ (P)", 1920, 1080);
            tool.CastFixedSize("iPhone X/XS (P)", 2436, 1125);
            tool.CastFixedSize("iPhone 11/XR (P)", 1792, 828);
            tool.CastFixedSize("iPhone 11 Pro (P)", 2436, 1125);
            tool.CastFixedSize("iPhone 12/13 (P)", 2532, 1170);
            tool.CastFixedSize("iPhone 12/13 Pro Max (P)", 2778, 1284);

            EditorUtility.DisplayDialog("View Size Tool", "Successfully created iOS landscape defaults! (Can be viewed when the current build platform is iOS)", "Understood");
        }
    }
}