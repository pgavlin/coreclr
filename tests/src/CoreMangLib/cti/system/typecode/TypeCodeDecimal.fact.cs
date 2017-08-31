using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeDecimal_TypeCodeDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeDecimal_TypeCodeDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeDecimal\\TypeCodeDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
