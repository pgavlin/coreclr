using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow0_cs_r_pow0_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow0_cs_r_pow0_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow0_cs_r\\pow0_cs_r.cmd");
        }
    }
}
