using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int64_Int64IConvertibleToDecimal_Int64IConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_int64_Int64IConvertibleToDecimal_Int64IConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int64\\Int64IConvertibleToDecimal\\Int64IConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
