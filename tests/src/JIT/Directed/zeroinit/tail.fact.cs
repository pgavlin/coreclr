using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_tail_tail_
    {
        [Fact]
        public void _zeroinit_tail_tail_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\tail\\tail.cmd");
        }
    }
}
