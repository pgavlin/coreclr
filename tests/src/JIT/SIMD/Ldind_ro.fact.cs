using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Ldind_ro_Ldind_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Ldind_ro_Ldind_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Ldind_ro\\Ldind_ro.cmd");
        }
    }
}
