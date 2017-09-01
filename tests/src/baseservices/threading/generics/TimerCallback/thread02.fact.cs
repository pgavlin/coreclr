using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_TimerCallback_thread02_thread02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread02_thread02_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread02\\thread02.cmd");
        }
    }
}
