using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow3_cs_d_pow3_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_d_pow3_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_d\\pow3_cs_d.cmd");
        }
    }
}
