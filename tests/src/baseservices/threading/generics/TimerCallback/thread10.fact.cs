using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_TimerCallback_thread10_thread10_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread10_thread10_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread10\\thread10.cmd");
        }
    }
}
