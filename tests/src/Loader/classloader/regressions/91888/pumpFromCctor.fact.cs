using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_91888_pumpFromCctor_pumpFromCctor_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_91888_pumpFromCctor_pumpFromCctor_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\91888\\pumpFromCctor\\pumpFromCctor.cmd");
        }
    }
}
