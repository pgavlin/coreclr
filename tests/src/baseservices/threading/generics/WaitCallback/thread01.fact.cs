using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_WaitCallback_thread01_thread01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread01_thread01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread01\\thread01.cmd");
        }
    }
}
