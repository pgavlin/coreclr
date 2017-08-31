using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64IConvertibleToDateTime_Int64IConvertibleToDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64IConvertibleToDateTime_Int64IConvertibleToDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64IConvertibleToDateTime\\Int64IConvertibleToDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
