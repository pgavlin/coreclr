using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Ctors_ro_Ctors_ro_
    {
        [Fact]
        public void _Ctors_ro_Ctors_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Ctors_ro\\Ctors_ro.cmd");
        }
    }
}
