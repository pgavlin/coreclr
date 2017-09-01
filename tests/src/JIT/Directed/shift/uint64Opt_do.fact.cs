using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64Opt_do_uint64Opt_do_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_do_uint64Opt_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_do\\uint64Opt_do.cmd");
        }
    }
}
