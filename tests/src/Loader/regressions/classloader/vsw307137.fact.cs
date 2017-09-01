using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    public class _classloader_vsw307137_vsw307137_
    {
        [OuterLoop]
        [Fact]
        public void _classloader_vsw307137_vsw307137_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\regressions\\classloader\\vsw307137\\vsw307137.cmd");
        }
    }
}
