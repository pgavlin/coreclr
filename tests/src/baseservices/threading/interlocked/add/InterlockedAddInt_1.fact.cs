using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddInt_1_InterlockedAddInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_1_InterlockedAddInt_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt_1\\InterlockedAddInt_1.cmd");
        }
    }
}
