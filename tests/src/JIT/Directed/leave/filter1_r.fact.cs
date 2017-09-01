using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_filter1_r_filter1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter1_r_filter1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter1_r\\filter1_r.cmd");
        }
    }
}
