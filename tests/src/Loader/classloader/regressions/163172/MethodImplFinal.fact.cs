using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_163172_MethodImplFinal_MethodImplFinal_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_163172_MethodImplFinal_MethodImplFinal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\163172\\MethodImplFinal\\MethodImplFinal.cmd");
        }
    }
}
