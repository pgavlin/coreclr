using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_catch3_r_catch3_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_catch3_r_catch3_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\catch3_r\\catch3_r.cmd");
        }
    }
}
