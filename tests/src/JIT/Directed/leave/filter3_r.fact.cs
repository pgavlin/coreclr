using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_filter3_r_filter3_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter3_r_filter3_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter3_r\\filter3_r.cmd");
        }
    }
}
