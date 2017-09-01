using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow3_cs_do_pow3_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow3_cs_do_pow3_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow3_cs_do\\pow3_cs_do.cmd");
        }
    }
}
