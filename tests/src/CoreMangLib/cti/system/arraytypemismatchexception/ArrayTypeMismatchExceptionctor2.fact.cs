using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor2_ArrayTypeMismatchExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_arraytypemismatchexception_ArrayTypeMismatchExceptionctor2_ArrayTypeMismatchExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\arraytypemismatchexception\\ArrayTypeMismatchExceptionctor2\\ArrayTypeMismatchExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
