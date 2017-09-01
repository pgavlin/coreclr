using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartLong_2_ThreadStartLong_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartLong_2_ThreadStartLong_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartLong_2\\ThreadStartLong_2.cmd");
        }
    }
}
