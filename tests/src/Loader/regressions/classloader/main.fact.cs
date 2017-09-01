using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    public class _classloader_main_main_
    {
        [OuterLoop]
        [Fact]
        public void _classloader_main_main_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\regressions\\classloader\\main\\main.cmd");
        }
    }
}
