using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_int64_do_int64_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_int64_do_int64_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\int64_do\\int64_do.cmd");
        }
    }
}
