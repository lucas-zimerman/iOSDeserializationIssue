using System;
using Xamarin.Forms;
using Sentry;

namespace SerializationIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public static void SentryInit()
        {
            SentryXamarin.Init(option =>
            {
                option.Debug = true;
                option.SendDefaultPii = true;
                option.ReportAssemblies = false;
                option.AddXamarinFormsIntegration();
                option.Dsn = "https://5a193123a9b841bc8d8e42531e7242a1@o447951.ingest.sentry.io/5560112";
                /*
                var cOptions = new ContribSentryOptions(cacheEnable: true)
                {
                    CacheDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "logs"),
                    GlobalSessionMode = true
                };
                cOptions.DisableEventCaching();
                option.AddIntegration(new ContribSentrySdkIntegration(cOptions));
                */
            });
        }
    }
}
