using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartLong_ThreadStartLong_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartLong_ThreadStartLong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartLong\\ThreadStartLong.cmd");
        }
    }
}
