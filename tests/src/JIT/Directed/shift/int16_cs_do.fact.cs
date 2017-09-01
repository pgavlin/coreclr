using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int16_cs_do_int16_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int16_cs_do_int16_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int16_cs_do\\int16_cs_do.cmd");
        }
    }
}
