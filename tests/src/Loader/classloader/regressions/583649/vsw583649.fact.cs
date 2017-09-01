using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_583649_vsw583649_vsw583649_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_583649_vsw583649_vsw583649_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\583649\\vsw583649\\vsw583649.cmd");
        }
    }
}
