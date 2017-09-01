using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartFloat_ThreadStartFloat_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartFloat_ThreadStartFloat_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartFloat\\ThreadStartFloat.cmd");
        }
    }
}
