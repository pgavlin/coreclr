using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow2_cs_ro_pow2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow2_cs_ro_pow2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow2_cs_ro\\pow2_cs_ro.cmd");
        }
    }
}
