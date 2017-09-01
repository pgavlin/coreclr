using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_nativeint_il_r_nativeint_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_nativeint_il_r_nativeint_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\nativeint_il_r\\nativeint_il_r.cmd");
        }
    }
}
