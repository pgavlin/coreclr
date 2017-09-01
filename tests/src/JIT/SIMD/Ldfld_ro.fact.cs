using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Ldfld_ro_Ldfld_ro_
    {
        [Fact]
        public void _Ldfld_ro_Ldfld_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Ldfld_ro\\Ldfld_ro.cmd");
        }
    }
}
