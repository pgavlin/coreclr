using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartDouble_ThreadStartDouble_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartDouble_ThreadStartDouble_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartDouble\\ThreadStartDouble.cmd");
        }
    }
}
