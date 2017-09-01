using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_misc_mutexctor1_mutexctor1_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_mutexctor1_mutexctor1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\mutexctor1\\mutexctor1.cmd");
        }
    }
}
