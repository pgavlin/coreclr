using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_vsw188290_vsw188290_vsw188290_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw188290_vsw188290_vsw188290_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw188290\\vsw188290\\vsw188290.cmd");
        }
    }
}
