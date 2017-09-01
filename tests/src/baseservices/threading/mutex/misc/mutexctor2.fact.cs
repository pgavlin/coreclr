using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_misc_mutexctor2_mutexctor2_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_mutexctor2_mutexctor2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\mutexctor2\\mutexctor2.cmd");
        }
    }
}
