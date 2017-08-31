using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64IConvertibleToSByte_Int64IConvertibleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64IConvertibleToSByte_Int64IConvertibleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64IConvertibleToSByte\\Int64IConvertibleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
