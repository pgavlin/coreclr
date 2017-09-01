using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64Opt_d_uint64Opt_d_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_d_uint64Opt_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_d\\uint64Opt_d.cmd");
        }
    }
}
