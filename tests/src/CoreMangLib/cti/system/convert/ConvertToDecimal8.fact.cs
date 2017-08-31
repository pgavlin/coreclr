using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal8_ConvertToDecimal8_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal8_ConvertToDecimal8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal8\\ConvertToDecimal8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
