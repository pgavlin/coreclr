using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0041_expl_double_1_expl_double_1_
    {
        [OuterLoop]
        [Fact]
        public void _0041_expl_double_1_expl_double_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0041\\expl_double_1\\expl_double_1.cmd");
        }
    }
}
