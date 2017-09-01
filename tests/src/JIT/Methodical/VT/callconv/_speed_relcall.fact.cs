using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_callconv__speed_relcall__speed_relcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_relcall__speed_relcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_relcall\\_speed_relcall.cmd");
        }
    }
}
