using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartShort_ThreadStartShort_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartShort_ThreadStartShort_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartShort\\ThreadStartShort.cmd");
        }
    }
}
