using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_callconv__relcall__relcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__relcall__relcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_relcall\\_relcall.cmd");
        }
    }
}
