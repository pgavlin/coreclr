using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_TimerCallback_thread01_thread01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TimerCallback_thread01_thread01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\TimerCallback\\thread01\\thread01.cmd");
        }
    }
}
