using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Shift_Shift_
    {
        [OuterLoop]
        [Fact]
        public void _Shift_Shift_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Shift\\Shift.cmd");
        }
    }
}
