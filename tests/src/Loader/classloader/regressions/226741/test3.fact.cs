using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_226741_test3_test3_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_226741_test3_test3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\226741\\test3\\test3.cmd");
        }
    }
}
