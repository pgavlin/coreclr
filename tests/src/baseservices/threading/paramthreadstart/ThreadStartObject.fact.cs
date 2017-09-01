using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartObject_ThreadStartObject_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartObject_ThreadStartObject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartObject\\ThreadStartObject.cmd");
        }
    }
}
