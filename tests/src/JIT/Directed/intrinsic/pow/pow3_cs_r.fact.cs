using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow3_cs_r_pow3_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_r_pow3_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_r\\pow3_cs_r.cmd");
        }
    }
}
