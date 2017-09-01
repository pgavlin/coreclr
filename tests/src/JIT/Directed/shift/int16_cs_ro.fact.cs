using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_cs_ro_int16_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_cs_ro_int16_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_cs_ro\\int16_cs_ro.cmd");
        }
    }
}
