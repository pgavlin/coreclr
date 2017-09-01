using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_regressions_433497_vsw433497_vsw433497_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_433497_vsw433497_vsw433497_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\433497\\vsw433497\\vsw433497.cmd");
        }
    }
}
