using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_catch2_r_catch2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch2_r_catch2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch2_r\\catch2_r.cmd");
        }
    }
}
