using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_catch1_r_catch1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch1_r_catch1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch1_r\\catch1_r.cmd");
        }
    }
}
