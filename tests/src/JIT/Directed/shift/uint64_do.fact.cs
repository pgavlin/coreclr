using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64_do_uint64_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_do_uint64_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_do\\uint64_do.cmd");
        }
    }
}
