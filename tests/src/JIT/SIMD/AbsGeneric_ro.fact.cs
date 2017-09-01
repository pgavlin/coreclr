using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AbsGeneric_ro_AbsGeneric_ro_
    {
        [Fact]
        public void _AbsGeneric_ro_AbsGeneric_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AbsGeneric_ro\\AbsGeneric_ro.cmd");
        }
    }
}
