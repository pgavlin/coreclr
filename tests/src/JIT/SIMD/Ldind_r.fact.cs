using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Ldind_r_Ldind_r_
    {
        [OuterLoop]
        [Fact]
        public void _Ldind_r_Ldind_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Ldind_r\\Ldind_r.cmd");
        }
    }
}
