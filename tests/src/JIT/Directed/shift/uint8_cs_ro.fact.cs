using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint8_cs_ro_uint8_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_cs_ro_uint8_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_cs_ro\\uint8_cs_ro.cmd");
        }
    }
}
