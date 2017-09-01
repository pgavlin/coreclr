using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _RightShiftRef_RightShiftRef_
    {
        [OuterLoop]
        [Fact]
        public void _RightShiftRef_RightShiftRef_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\RightShiftRef\\RightShiftRef.cmd");
        }
    }
}
