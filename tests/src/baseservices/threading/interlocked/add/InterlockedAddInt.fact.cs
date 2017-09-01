using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddInt_InterlockedAddInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_InterlockedAddInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt\\InterlockedAddInt.cmd");
        }
    }
}
