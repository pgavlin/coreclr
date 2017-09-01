using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Ldfld_r_Ldfld_r_
    {
        [Fact]
        public void _Ldfld_r_Ldfld_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Ldfld_r\\Ldfld_r.cmd");
        }
    }
}
