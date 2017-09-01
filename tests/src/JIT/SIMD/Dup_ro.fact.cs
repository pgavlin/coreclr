using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Dup_ro_Dup_ro_
    {
        [Fact]
        public void _Dup_ro_Dup_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Dup_ro\\Dup_ro.cmd");
        }
    }
}
