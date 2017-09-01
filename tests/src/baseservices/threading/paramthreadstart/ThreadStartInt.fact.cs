using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartInt_ThreadStartInt_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartInt_ThreadStartInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartInt\\ThreadStartInt.cmd");
        }
    }
}
