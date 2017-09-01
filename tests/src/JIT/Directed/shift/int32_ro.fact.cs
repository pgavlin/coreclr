using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int32_ro_int32_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int32_ro_int32_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int32_ro\\int32_ro.cmd");
        }
    }
}
