using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueEqFP_JTrueEqFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueEqFP_JTrueEqFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueEqFP\\JTrueEqFP.cmd");
        }
    }
}
