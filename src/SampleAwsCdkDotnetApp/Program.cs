using Amazon.CDK;

namespace SampleAwsCdkDotnetApp
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new SampleAwsCdkDotnetAppStack(app, "SampleAwsCdkDotnetAppStack");

            app.Synth();
        }
    }
}
