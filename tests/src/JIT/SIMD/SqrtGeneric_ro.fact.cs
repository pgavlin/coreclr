using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _SqrtGeneric_ro_SqrtGeneric_ro_
    {
        [Fact]
        public void _SqrtGeneric_ro_SqrtGeneric_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\SqrtGeneric_ro\\SqrtGeneric_ro.cmd");
        }
    }
}
