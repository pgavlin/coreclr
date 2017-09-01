using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_filter1_d_filter1_d_
    {
        [OuterLoop]
        [Fact]
        public void _leave_filter1_d_filter1_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\filter1_d\\filter1_d.cmd");
        }
    }
}
