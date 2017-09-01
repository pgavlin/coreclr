using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0582_csgen_1_csgen_1_
    {
        [OuterLoop]
        [Fact]
        public void _0582_csgen_1_csgen_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0582\\csgen.1\\csgen.1.cmd");
        }
    }
}
