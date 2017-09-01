using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartULong_ThreadStartULong_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartULong_ThreadStartULong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartULong\\ThreadStartULong.cmd");
        }
    }
}
