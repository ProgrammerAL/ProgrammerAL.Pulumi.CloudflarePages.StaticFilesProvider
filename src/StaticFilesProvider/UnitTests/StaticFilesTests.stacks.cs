using ProgrammerAL.PulumiComponent.CloudflarePages.StaticFilesComponent;

using Pulumi;

namespace UnitTests;

public class HappyPathStack : Stack
{
    public HappyPathStack()
    {
        _ = Directory.CreateDirectory(@"./files");
        _ = new StaticFiles($"test-files", new StaticFilesArgs
        {
            ProjectName = "test-files",
            UploadDirectory = @"./files",
            Branch = "my-branch",
        });
    }
}
