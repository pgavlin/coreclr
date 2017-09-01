using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow0_cs_d_pow0_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow0_cs_d_pow0_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow0_cs_d\\pow0_cs_d.cmd");
        }
    }
}
