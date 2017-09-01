using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_pow_pow1_pow1_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_pow_pow1_pow1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\pow\\pow1\\pow1.cmd");
        }
    }
}
