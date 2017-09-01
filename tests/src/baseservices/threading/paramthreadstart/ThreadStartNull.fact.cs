using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartNull_ThreadStartNull_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartNull_ThreadStartNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartNull\\ThreadStartNull.cmd");
        }
    }
}
