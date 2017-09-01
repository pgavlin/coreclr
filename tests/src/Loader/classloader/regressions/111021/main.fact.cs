using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_111021_main_main_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_111021_main_main_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\111021\\main\\main.cmd");
        }
    }
}
