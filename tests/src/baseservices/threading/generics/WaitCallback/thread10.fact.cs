using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_WaitCallback_thread10_thread10_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread10_thread10_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread10\\thread10.cmd");
        }
    }
}
