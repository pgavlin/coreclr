using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64IConvertibleToUInt16_Int64IConvertibleToUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64IConvertibleToUInt16_Int64IConvertibleToUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64IConvertibleToUInt16\\Int64IConvertibleToUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
