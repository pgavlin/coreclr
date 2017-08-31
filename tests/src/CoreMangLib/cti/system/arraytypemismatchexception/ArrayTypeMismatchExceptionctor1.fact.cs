using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor1_ArrayTypeMismatchExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor1_ArrayTypeMismatchExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\arraytypemismatchexception\\ArrayTypeMismatchExceptionctor1\\ArrayTypeMismatchExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
