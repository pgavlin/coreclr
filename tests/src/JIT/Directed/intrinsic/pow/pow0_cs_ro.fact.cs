using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow0_cs_ro_pow0_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow0_cs_ro_pow0_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow0_cs_ro\\pow0_cs_ro.cmd");
        }
    }
}
