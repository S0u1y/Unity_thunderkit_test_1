//using RoR2.ContentManagement;
//using RoR2;
//using System.Collections;
//using System.Reflection;
//using UnityEngine;
//using Path = System.IO.Path;

//public class SomeNewCode
//{
//    public static class Assets
//    {
//        public static AssetBundle mainAssetBundle = null;
//        //the filename of your assetbundle
//        internal static string assetBundleName = "IAmSoFuckingSad";

//        internal static string assemblyDir
//        {
//            get
//            {
//                return Path.GetDirectoryName(Main.Info.Location);
//            }
//        }

//        public static void PopulateAssets()
//        {
//            mainAssetBundle = AssetBundle.LoadFromFile(Path.Combine(assemblyDir, assetBundleName));
//            ContentPackProvider.serializedContentPack = mainAssetBundle.LoadAsset<SerializableContentPack>(ContentPackProvider.contentPackName);
//        }
//    }

//    public class ContentPackProvider : IContentPackProvider
//    {
//        public static SerializableContentPack serializedContentPack;
//        public static ContentPack contentPack;
//        //Should be the same names as your SerializableContentPack in the asset bundle
//        public static string contentPackName = "MuchContent";

//        public string identifier
//        {
//            get
//            {
//                //If I see this name while loading a mod I will make fun of you
//                return "YuumiMod";
//            }
//        }

//        internal static void Initialize()
//        {
//            contentPack = serializedContentPack.CreateContentPack();
//            ContentManager.collectContentPackProviders += AddCustomContent;
//        }

//        private static void AddCustomContent(ContentManager.AddContentPackProviderDelegate addContentPackProvider)
//        {
//            addContentPackProvider(new ContentPackProvider());
//        }

//        public IEnumerator LoadStaticContentAsync(LoadStaticContentAsyncArgs args)
//        {
//            args.ReportProgress(1f);
//            yield break;
//        }

//        public IEnumerator GenerateContentPackAsync(GetContentPackAsyncArgs args)
//        {
//            ContentPack.Copy(contentPack, args.output);
//            args.ReportProgress(1f);
//            yield break;
//        }

//        public IEnumerator FinalizeAsync(FinalizeAsyncArgs args)
//        {
//            args.ReportProgress(1f);
//            yield break;
//        }
//    }
//}
