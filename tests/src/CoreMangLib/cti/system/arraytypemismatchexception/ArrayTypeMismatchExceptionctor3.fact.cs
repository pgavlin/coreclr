using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor3_ArrayTypeMismatchExceptionctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor3_ArrayTypeMismatchExceptionctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\arraytypemismatchexception\\ArrayTypeMismatchExceptionctor3\\ArrayTypeMismatchExceptionctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
