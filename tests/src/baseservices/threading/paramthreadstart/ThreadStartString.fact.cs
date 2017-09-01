using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartString_ThreadStartString_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartString_ThreadStartString_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartString\\ThreadStartString.cmd");
        }
    }
}
