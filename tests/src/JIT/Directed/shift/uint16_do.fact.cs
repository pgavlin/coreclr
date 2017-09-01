using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint16_do_uint16_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint16_do_uint16_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint16_do\\uint16_do.cmd");
        }
    }
}
