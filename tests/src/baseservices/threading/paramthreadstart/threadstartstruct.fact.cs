using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_threadstartstruct_threadstartstruct_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_threadstartstruct_threadstartstruct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\threadstartstruct\\threadstartstruct.cmd");
        }
    }
}
