using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _rtchecks_overflow_overflow01_div_overflow01_div_
    {
        [Fact]
        public void _rtchecks_overflow_overflow01_div_overflow01_div_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\rtchecks\\overflow\\overflow01_div\\overflow01_div.cmd");
        }
    }
}
