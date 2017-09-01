using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64Opt_r_uint64Opt_r_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64Opt_r_uint64Opt_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64Opt_r\\uint64Opt_r.cmd");
        }
    }
}
