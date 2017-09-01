using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_filter2_r_filter2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter2_r_filter2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter2_r\\filter2_r.cmd");
        }
    }
}
