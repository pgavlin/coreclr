using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_nativeint_il_d_nativeint_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeint_il_d_nativeint_il_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeint_il_d\\nativeint_il_d.cmd");
        }
    }
}
