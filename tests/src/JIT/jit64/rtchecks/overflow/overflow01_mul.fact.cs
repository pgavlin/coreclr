using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _rtchecks_overflow_overflow01_mul_overflow01_mul_
    {
        [Fact]
        public void _rtchecks_overflow_overflow01_mul_overflow01_mul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow01_mul\\overflow01_mul.cmd");
        }
    }
}
