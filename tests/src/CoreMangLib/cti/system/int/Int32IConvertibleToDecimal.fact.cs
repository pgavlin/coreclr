using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToDecimal_Int32IConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToDecimal_Int32IConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToDecimal\\Int32IConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
