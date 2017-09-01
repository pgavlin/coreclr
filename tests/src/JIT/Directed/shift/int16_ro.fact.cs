using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_ro_int16_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_ro_int16_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_ro\\int16_ro.cmd");
        }
    }
}
