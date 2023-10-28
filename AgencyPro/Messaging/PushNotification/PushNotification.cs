using System.Collections.Generic;
using AgencyPro.Common.Enums;

namespace AgencyPro.Messaging.PushNotification
{
    public class PushNotification
    {
        private const string DefaultSound = "sound.caf";
        private const string DefaultSoundFormat = ".mp3";
        private string _sound;

        public PushNotification()
        {
            Badge = 0;
            Vibrate = true;
            Silent = true;
            Params = new Dictionary<string, object>();
        }

        public MobileOS DeviceOS { get; set; }
        public string DeviceToken { get; set; }
        public string[] DeviceTokens { get; set; }
        public string Icon { get; set; }
        public string Channel { get; set; }
        public string Message { get; set; }

        public string Sound
        {
            get =>
                !string.IsNullOrEmpty(_sound)
                    ? (_sound.Contains(DefaultSoundFormat)
                        ? _sound
                        : string.Format("{0}{1}", _sound, DefaultSoundFormat)).ToLower()
                    : DefaultSound;
            set => _sound = value;
        }

        public int Badge { get; set; }
        public bool Vibrate { get; set; }
        public bool Silent { get; set; }
        public Dictionary<string, object> Params { get; set; }
    }
}