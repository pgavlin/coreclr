using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _generics_WaitCallback_thread16_thread16_
    {
        [OuterLoop]
        [Fact]
        public void _generics_WaitCallback_thread16_thread16_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\generics\\WaitCallback\\thread16\\thread16.cmd");
        }
    }
}
