using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow3_cs_ro_pow3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_ro_pow3_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_ro\\pow3_cs_ro.cmd");
        }
    }
}
