using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint8_cs_do_uint8_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint8_cs_do_uint8_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint8_cs_do\\uint8_cs_do.cmd");
        }
    }
}
