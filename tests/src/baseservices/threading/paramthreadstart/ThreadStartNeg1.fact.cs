using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartNeg1_ThreadStartNeg1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNeg1_ThreadStartNeg1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNeg1\\ThreadStartNeg1.cmd");
        }
    }
}
