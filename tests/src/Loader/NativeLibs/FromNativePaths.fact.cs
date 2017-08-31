using CoreclrTestLib;
using Xunit;

namespace Loader_NativeLibs
{
    class _FromNativePaths_FromNativePaths_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _FromNativePaths_FromNativePaths_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\NativeLibs\\FromNativePaths\\FromNativePaths.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
