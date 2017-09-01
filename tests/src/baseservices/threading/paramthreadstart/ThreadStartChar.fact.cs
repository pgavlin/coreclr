using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartChar_ThreadStartChar_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartChar_ThreadStartChar_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartChar\\ThreadStartChar.cmd");
        }
    }
}
