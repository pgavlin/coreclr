using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_cs_ro_uint16_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_cs_ro_uint16_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_cs_ro\\uint16_cs_ro.cmd");
        }
    }
}
