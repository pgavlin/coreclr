using CoreclrTestLib;
using Xunit;

namespace Loader_NativeLibs
{
    public class _FromNativePaths_FromNativePaths_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _FromNativePaths_FromNativePaths_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\NativeLibs\\FromNativePaths\\FromNativePaths.cmd");
        }
    }
}
