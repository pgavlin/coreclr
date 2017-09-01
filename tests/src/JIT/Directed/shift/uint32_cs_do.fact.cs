using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint32_cs_do_uint32_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_cs_do_uint32_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_cs_do\\uint32_cs_do.cmd");
        }
    }
}
