using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueEqDbl_JTrueEqDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueEqDbl_JTrueEqDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueEqDbl\\JTrueEqDbl.cmd");
        }
    }
}
