using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueEqInt1_JTrueEqInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueEqInt1_JTrueEqInt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueEqInt1\\JTrueEqInt1.cmd");
        }
    }
}
