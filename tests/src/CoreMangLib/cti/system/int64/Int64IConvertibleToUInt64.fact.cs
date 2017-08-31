using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64IConvertibleToUInt64_Int64IConvertibleToUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64IConvertibleToUInt64_Int64IConvertibleToUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64IConvertibleToUInt64\\Int64IConvertibleToUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
