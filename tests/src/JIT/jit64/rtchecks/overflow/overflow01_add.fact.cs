using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _rtchecks_overflow_overflow01_add_overflow01_add_
    {
        [Fact]
        public void _rtchecks_overflow_overflow01_add_overflow01_add_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow01_add\\overflow01_add.cmd");
        }
    }
}
