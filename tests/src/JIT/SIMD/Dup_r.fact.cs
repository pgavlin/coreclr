using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Dup_r_Dup_r_
    {
        [Fact]
        public void _Dup_r_Dup_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Dup_r\\Dup_r.cmd");
        }
    }
}
