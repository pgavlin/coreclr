using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _FPtrunc_convx_il_r_convx_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convx_il_r_convx_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convx_il_r\\convx_il_r.cmd");
        }
    }
}
