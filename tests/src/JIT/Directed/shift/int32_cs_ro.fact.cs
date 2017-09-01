using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_cs_ro_int32_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_cs_ro_int32_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_cs_ro\\int32_cs_ro.cmd");
        }
    }
}
