using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint32_cs_ro_uint32_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint32_cs_ro_uint32_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint32_cs_ro\\uint32_cs_ro.cmd");
        }
    }
}
