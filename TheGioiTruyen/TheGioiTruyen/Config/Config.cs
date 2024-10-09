

namespace ACBSChatbotConnector.Config
{
    public static class Config
    {
               
        public static string RootFolder
        {
            get
            {
                try
                {
                    string di = AppDomain.CurrentDomain.BaseDirectory;
                    return di;
                }
                catch
                {
                    return "/";
                }
            }

        }

        public static string UPLOAD_MEDIA_FOLDER = "static";

        public static string[] IMAGE_EXTENSION_ACCEPT = {
            ".jpg", ".png", ".bpm", ".jpeg", ".tiff", ".raw", ".heic", ".heif",
            ".gif"
        };

        public static string[] VIDEO_EXTENSION_ACCEPT = {
            ".mp4", ".mov", ".wmv"
        };
    }
}
