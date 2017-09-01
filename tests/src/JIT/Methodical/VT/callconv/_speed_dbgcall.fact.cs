using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _VT_callconv__speed_dbgcall__speed_dbgcall_
    {
        [OuterLoop]
        [Fact]
        public void _VT_callconv__speed_dbgcall__speed_dbgcall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\callconv\\_speed_dbgcall\\_speed_dbgcall.cmd");
        }
    }
}
