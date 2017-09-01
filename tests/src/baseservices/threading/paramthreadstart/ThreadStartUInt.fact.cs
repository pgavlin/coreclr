using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartUInt_ThreadStartUInt_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartUInt_ThreadStartUInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartUInt\\ThreadStartUInt.cmd");
        }
    }
}
