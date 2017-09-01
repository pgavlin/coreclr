using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_307137_vsw307137_vsw307137_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_307137_vsw307137_vsw307137_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\307137\\vsw307137\\vsw307137.cmd");
        }
    }
}
