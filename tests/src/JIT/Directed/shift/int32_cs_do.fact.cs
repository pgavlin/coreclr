using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_cs_do_int32_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_cs_do_int32_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_cs_do\\int32_cs_do.cmd");
        }
    }
}
