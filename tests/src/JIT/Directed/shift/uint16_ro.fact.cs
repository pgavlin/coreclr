using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_ro_uint16_ro_
    {
        [Fact]
        public void _shift_uint16_ro_uint16_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_ro\\uint16_ro.cmd");
        }
    }
}
