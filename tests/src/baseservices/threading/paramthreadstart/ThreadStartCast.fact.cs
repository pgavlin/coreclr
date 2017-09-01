using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartCast_ThreadStartCast_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartCast_ThreadStartCast_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartCast\\ThreadStartCast.cmd");
        }
    }
}
