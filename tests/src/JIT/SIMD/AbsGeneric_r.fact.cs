using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AbsGeneric_r_AbsGeneric_r_
    {
        [Fact]
        public void _AbsGeneric_r_AbsGeneric_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AbsGeneric_r\\AbsGeneric_r.cmd");
        }
    }
}
