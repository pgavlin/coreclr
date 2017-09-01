using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddLongWithSubtract_InterlockedAddLongWithSubtract_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLongWithSubtract_InterlockedAddLongWithSubtract_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLongWithSubtract\\InterlockedAddLongWithSubtract.cmd");
        }
    }
}
